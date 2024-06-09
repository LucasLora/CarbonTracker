using CarbonTracker.Models;
using CarbonTracker.Models.Models;
using CarbonTracker.Models.RepositoriesInterfaces;
using CarbonTracker.Presenters.Common;
using CarbonTracker.Views;
using CarbonTracker.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class EntrarGrupoPresenter
    {

        #region Campos

        private UsuarioModel usuarioLogado;
        private IEntrarGrupoView view;
        IUsuarioXGrupoUsuariosRepository repositoryUsuarioXGrupoDeUsuarios;

        private BindingSource grupoUsuariosBindingSource = new BindingSource();
        private IEnumerable<UsuarioXGrupoUsuariosModel> usuarioXGrupoUsuariosList;

        #endregion

        #region Construtor

        public EntrarGrupoPresenter(UsuarioModel usuarioLogado,
                                    IEntrarGrupoView view,
                                    IUsuarioXGrupoUsuariosRepository repositoryUsuarioXGrupoDeUsuarios)
        {
            this.usuarioLogado = usuarioLogado;
            this.view = view;
            this.repositoryUsuarioXGrupoDeUsuarios = repositoryUsuarioXGrupoDeUsuarios;

            VincularEventos();
            SetBindings();
            CarregaTodaListaDeGruposUsuariosDoUsuario();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.SearchEvent += SearchGrupoUsuarios;
            this.view.SalvarEvent += SalvarGrupoUsuarios;
            this.view.RestaurarEvent += RestaurarAcao;
        }

        private void SetBindings()
        {
            this.view.SetGrupoUsuariosListBindingSource(grupoUsuariosBindingSource);
        }

        private void CarregaTodaListaDeGruposUsuariosDoUsuario()
        {
            usuarioXGrupoUsuariosList = repositoryUsuarioXGrupoDeUsuarios.RetornarTodosGruposComInformacoesDePresencaDoUsuario(usuarioLogado.Id);
            grupoUsuariosBindingSource.DataSource = usuarioXGrupoUsuariosList;
        }

        #endregion

        #region Eventos

        private void SearchGrupoUsuarios(object sender, EventArgs e)
        {
            var valorPesquisa = this.view.SearchValue;

            if (!string.IsNullOrWhiteSpace(valorPesquisa))
            {
                valorPesquisa = valorPesquisa.ToLower();

                var lst = usuarioXGrupoUsuariosList.Where(x => x.IdGrupo.ToString() == valorPesquisa ||
                                                          x.NomeGrupoNRT.ToLower().Contains(valorPesquisa));

                if (lst.Count() == 0) //Se não encontrar nada, retorna a lista completa
                {
                    lst = usuarioXGrupoUsuariosList;
                }

                grupoUsuariosBindingSource.DataSource = lst;
            }
            else
            {
                grupoUsuariosBindingSource.DataSource = usuarioXGrupoUsuariosList;
            }
        }

        private void SalvarGrupoUsuarios(object sender, EventArgs e)
        {
            try
            {
                repositoryUsuarioXGrupoDeUsuarios.ExcluirPorUsuario(usuarioLogado.Id);

                usuarioXGrupoUsuariosList.ToList().ForEach(x =>
                {
                    if (x.PresenteNRT)
                    {
                        repositoryUsuarioXGrupoDeUsuarios.Adicionar(x);
                    }
                });

                view.IsSuccessful = true;
                view.Message = "Grupos de usuários salvos com sucesso!";
                CarregaTodaListaDeGruposUsuariosDoUsuario();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void RestaurarAcao(object sender, EventArgs e)
        {
            CarregaTodaListaDeGruposUsuariosDoUsuario();
        }

        #endregion

    }
}
