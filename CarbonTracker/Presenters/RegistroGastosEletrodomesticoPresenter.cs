using CarbonTracker.Models.Models;
using CarbonTracker.Models.RepositoriesInterfaces;
using CarbonTracker.Models;
using CarbonTracker.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace CarbonTracker.Presenters
{
    public class RegistroGastosEletrodomesticoPresenter
    {

        #region Campos

        private UsuarioModel usuarioLogado;
        private IRegistroGastosEletrodomesticoView view;
        IGastosEletrodomesticoRepository repository;

        private BindingSource gastosEletrodomesticoBindingSource = new BindingSource();
        private IEnumerable<GastosEletrodomesticoModel> gastosEletrodomesticoList;

        #endregion

        #region Construtor

        public RegistroGastosEletrodomesticoPresenter(UsuarioModel usuarioLogado,
                                                      IRegistroGastosEletrodomesticoView view,
                                                      IGastosEletrodomesticoRepository repository)
        {
            this.usuarioLogado = usuarioLogado;
            this.view = view;
            this.repository = repository;

            VincularEventos();
            SetBindings();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.RegistrarDiaEvent += RegistrarGastosDia;
            this.view.TrocarDiaEvent += TrocarDia;
            this.view.SearchEvent += SearchGrupoUsuarios;
            this.view.SalvarEvent += SalvarGrupoUsuarios;
            this.view.RestaurarEvent += RestaurarAcao;
        }

        private void SetBindings()
        {
            this.view.SetGastosEletrodomesticoListBindingSource(gastosEletrodomesticoBindingSource);
        }

        private bool ValidaDia()
        {
            var dia = view.Dia.Date;

            if (dia > DateTime.Now.Date || dia < SqlDateTime.MinValue.Value.Date)
            {
                view.IsSuccessful = false;
                view.Message = "Data inválida!";
                return false;
            }

            view.IsSuccessful = true;
            view.Message = $"Registros de gastos para o dia {dia.ToString("dd/MM/yyyy")}!";
            return true;
        }

        private void CarregaTodaListaDeRegistrosEletrodomestico(long usuarioId, DateTime dia)
        {
            gastosEletrodomesticoList = repository.RetornarPorUsuarioEDia(usuarioId, dia);
            gastosEletrodomesticoBindingSource.DataSource = gastosEletrodomesticoList;
        }

        private void LimpaTodaListaDeRegistrosEletrodomestico()
        {
            gastosEletrodomesticoList = new List<GastosEletrodomesticoModel>();
            gastosEletrodomesticoBindingSource.DataSource = gastosEletrodomesticoList;
        }

        #endregion

        #region Eventos

        private void RegistrarGastosDia(object sender, EventArgs e)
        {
            if (ValidaDia())
            {
                CarregaTodaListaDeRegistrosEletrodomestico(usuarioLogado.Id, view.Dia.Date);
                view.BloquearDiaEDesbloquearRegistro(true);
            }
        }

        private void TrocarDia(object sender, EventArgs e)
        {
            LimpaTodaListaDeRegistrosEletrodomestico();
            view.BloquearDiaEDesbloquearRegistro(false);
        }

        private void SearchGrupoUsuarios(object sender, EventArgs e)
        {
            var valorPesquisa = this.view.SearchValue;

            if (!string.IsNullOrWhiteSpace(valorPesquisa))
            {
                valorPesquisa = valorPesquisa.ToLower();

                var lst = gastosEletrodomesticoList.Where(x => x.IdEletrodomestico.ToString() == valorPesquisa ||
                                                          x.NomeNRT.ToLower().Contains(valorPesquisa));

                if (lst.Count() == 0) //Se não encontrar nada, retorna a lista completa
                {
                    lst = gastosEletrodomesticoList;
                }

                gastosEletrodomesticoBindingSource.DataSource = lst;
            }
            else
            {
                gastosEletrodomesticoBindingSource.DataSource = gastosEletrodomesticoList;
            }
        }

        private void SalvarGrupoUsuarios(object sender, EventArgs e)
        {
            try
            {
                //Se não existe o registro no banco, ou seja, o Id é 0, e possui dados de gastos relevantes, então insere
                //Se existe, ou seja, o Id é diferente de 0, então atualiza, mesmo sendo valores zerados

                foreach (var gasto in gastosEletrodomesticoList)
                {
                    if (gasto.Id == 0) //Inserir registro de gasto
                    {
                        if(gasto.TempoUso > 0) //Só insere se tiver registros de gastos relevantes
                        {
                            repository.Adicionar(gasto);
                        }
                    }
                    else //Atualizar registro de gasto
                    { 
                        //Atualiza, mesmo sendo valores zerados, para não precisar excluir e inserir novamente
                        repository.Alterar(gasto);
                    }
                }

                //Libera a tela novamente
                LimpaTodaListaDeRegistrosEletrodomestico();
                view.BloquearDiaEDesbloquearRegistro(false);

                view.IsSuccessful = true;
                view.Message = "Registros de gastos salvos com sucesso!";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void RestaurarAcao(object sender, EventArgs e)
        {
            //Não precisa validar, porque já validou quando clicou no botão registrar
            CarregaTodaListaDeRegistrosEletrodomestico(usuarioLogado.Id, view.Dia.Date);
        }

        #endregion

    }
}
