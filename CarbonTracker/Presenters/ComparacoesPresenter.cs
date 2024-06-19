using CarbonTracker._Repositories;
using CarbonTracker.Models.RepositoriesInterfaces;
using CarbonTracker.Models;
using CarbonTracker.Views.Interfaces;
using CarbonTracker.Views.Views;
using CarbonTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarbonTracker.Services;

namespace CarbonTracker.Presenters
{
    public class ComparacoesPresenter
    {

        #region Campos

        private readonly UsuarioModel usuarioLogado;
        private readonly CarbonTrackerService carbonTrackerService;
        private IComparacoesView view;
        private IGastosEletrodomesticoRepository gastosEletrodomesticoRepository;
        private IGastosTransporteRepository gastosTransporteRepository;
        private IUsuarioXGrupoUsuariosRepository usuarioXGrupoUsuariosRepository;

        private BindingSource posicaoGruposUsuarios = new BindingSource();

        #endregion

        #region Construtor

        public ComparacoesPresenter(UsuarioModel usuarioLogado,
                                    CarbonTrackerService carbonTrackerService,
                                    IComparacoesView view,
                                    IGastosEletrodomesticoRepository gastosEletrodomesticoRepository,
                                    IGastosTransporteRepository gastosTransporteRepository,
                                    IUsuarioXGrupoUsuariosRepository usuarioXGrupoUsuariosRepository)
        {
            this.usuarioLogado = usuarioLogado;
            this.carbonTrackerService = carbonTrackerService;
            this.view = view;
            this.gastosEletrodomesticoRepository = gastosEletrodomesticoRepository;
            this.gastosTransporteRepository = gastosTransporteRepository;
            this.usuarioXGrupoUsuariosRepository = usuarioXGrupoUsuariosRepository;

            VincularEventos();
            SetBindings();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.CompararEvent += Comparar;
            this.view.MensalEvent += Mensal;
            this.view.TrimestralEvent += Trimestral;
            this.view.SemestralEvent += Semestral;
            this.view.AnualEvent += Anual;
        }

        private void SetBindings()
        {
            this.view.SetPosicaoGruposUsuariosListBindingSource(posicaoGruposUsuarios);
        }

        private void SetDataFinalHoje()
        {
            view.DiaFinal = DateTime.Today.Date;
        }

        private void GerarComparacoes()
        {
            //Datas
            var diaInicial = view.DiaInicial.Date;
            var diaFinal = view.DiaFinal.Date;

            //Buscar gastos do usuário logado
            var gastosTransporte = gastosTransporteRepository
                .RetornaPorUsuarioEIntervaloDatasParaCalculo(idUsuario: usuarioLogado.Id, dataInicio: diaInicial, dataFim: diaFinal)
                .ToList();

            var gastosEletrodomesticos = gastosEletrodomesticoRepository
                .RetornaPorUsuarioEIntervaloDatasParaCalculo(idUsuario: usuarioLogado.Id, dataInicio: diaInicial, dataFim: diaFinal)
                .ToList();

            //Calcular pontuação do usuário logado
            var pontuacaoUsuario = carbonTrackerService.CalcularPegadaCarbonoTotal(registrosTransporte: gastosTransporte, registrosEletrodomesticos: gastosEletrodomesticos);

            //Vincular a pontuação ao txtPontuacao
            view.Pontuacao = pontuacaoUsuario.ToString("f2");

            //Lista para armazenar a posição do usuário em cada grupo
            var listaPosicaoGruposUsuarios = new List<PosicaoGruposUsuarios>();

            if (view.CompararGrupos)
            {
                //Buscar grupos que o usuário participa
                var gruposUsuario = usuarioXGrupoUsuariosRepository
                    .RetornarTodosGruposQueOUsuarioEhParticipante(idUsuario: usuarioLogado.Id)
                    .ToList();

                foreach (var grupo in gruposUsuario)
                {
                    //Calcular a pontuação dos usuários do grupo
                    var posicaoUsuario = CalcularPosicaoUsuarioNoGrupo(idGrupo: grupo.IdGrupo,
                                                                       diaInicial: diaInicial,
                                                                       diaFinal: diaFinal,
                                                                       pontuacaoUsuario: pontuacaoUsuario);

                    //Adicionar a posição do usuário no grupo à lista
                    listaPosicaoGruposUsuarios.Add(new PosicaoGruposUsuarios
                    {
                        IdGrupo = grupo.IdGrupo,
                        NomeGrupo = grupo.NomeGrupoNRT,
                        PosicaoGrupo = posicaoUsuario
                    });
                }
            }

            //Vincular os grupos ao BindingSource
            this.posicaoGruposUsuarios.DataSource = listaPosicaoGruposUsuarios;
        }

        //Método auxiliar para calcular a posição do usuário em um grupo
        private int CalcularPosicaoUsuarioNoGrupo(long idGrupo, DateTime diaInicial, DateTime diaFinal, double pontuacaoUsuario)
        {
            //Buscar IDs dos usuários do grupo
            var usuariosDoGrupo = usuarioXGrupoUsuariosRepository
                .RetornarTodosIdsUsuariosPorGrupo(idGrupo)
                .ToList();

            var pontuacoesUsuariosGrupo = new List<double>();

            //Iterar sobre os usuários do grupo e calcular suas pontuações
            foreach (var usuarioId in usuariosDoGrupo)
            {
                var gastosTransporte = gastosTransporteRepository
                    .RetornaPorUsuarioEIntervaloDatasParaCalculo(idUsuario: usuarioId, dataInicio: diaInicial, dataFim: diaFinal)
                    .ToList();

                var gastosEletrodomesticos = gastosEletrodomesticoRepository
                    .RetornaPorUsuarioEIntervaloDatasParaCalculo(idUsuario: usuarioId, dataInicio: diaInicial, dataFim: diaFinal)
                    .ToList();

                var pontuacao = carbonTrackerService.CalcularPegadaCarbonoTotal(gastosTransporte, gastosEletrodomesticos);
                pontuacoesUsuariosGrupo.Add(pontuacao);
            }

            //Ordenar as pontuações de forma decrescente
            pontuacoesUsuariosGrupo = pontuacoesUsuariosGrupo.OrderByDescending(p => p).ToList();

            //Tirar membros que não ao menos um gasto registrado
            pontuacoesUsuariosGrupo = pontuacoesUsuariosGrupo.Where(p => p > 0).ToList();

            //Calcular a posição do usuário logado
            var posicaoUsuario = pontuacoesUsuariosGrupo
                .Where(p => p <= pontuacaoUsuario)
                .Count();

            return posicaoUsuario;
        }

        #endregion

        #region Eventos

        private void Comparar(object sender, EventArgs e)
        {
            try 
            {
                view.BloquearBotoes(true);

                GerarComparacoes();

                view.Message = "Comparação realizada com sucesso!";
                view.IsSuccessful = true;
            }
            catch
            {
                view.Message = "Erro ao realizar a comparação";
                view.IsSuccessful = false;
            }
            finally
            {
                view.BloquearBotoes(false);
            }
        }

        private void Mensal(object sender, EventArgs e)
        {
            SetDataFinalHoje();
            view.DiaInicial = DateTime.Today.Date.AddMonths(-1);
        }

        private void Trimestral(object sender, EventArgs e)
        {
            SetDataFinalHoje();
            view.DiaInicial = DateTime.Today.Date.AddMonths(-3);
        }

        private void Semestral(object sender, EventArgs e)
        {
            SetDataFinalHoje();
            view.DiaInicial = DateTime.Today.Date.AddMonths(-6);
        }

        private void Anual(object sender, EventArgs e)
        {
            SetDataFinalHoje();
            view.DiaInicial = DateTime.Today.Date.AddYears(-1);
        }

        #endregion

        #region Classe Extra

        private class PosicaoGruposUsuarios
        {
            public long IdGrupo { get; set; }
            public string NomeGrupo { get; set; }
            public int PosicaoGrupo { get; set; }
        }

        #endregion

    }
}
