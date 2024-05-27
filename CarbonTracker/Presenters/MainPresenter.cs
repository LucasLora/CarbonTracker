using System;
using CarbonTracker.Views;
using CarbonTracker.Models;
using System.Windows.Forms;
using CarbonTracker.Views.Interfaces;
using CarbonTracker.Views.Views;

namespace CarbonTracker.Presenters
{
    public class MainPresenter
    {

        #region Campos

        private readonly UsuarioModel usuarioLogado;
        private IMainView mainView;
        private readonly string stringConexao;

        #endregion

        #region Construtor

        public MainPresenter(UsuarioModel usuarioLogado, IMainView mainView, string stringConexao)
        {
            this.usuarioLogado = usuarioLogado;
            this.mainView = mainView;
            this.stringConexao = stringConexao;

            VincularEventos();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.mainView.ShowUsuariosView += ShowUsuariosView;
            this.mainView.ShowCadastrosGastosView += ShowCadastrosGastosView;
            this.mainView.ShowRegistroGastosView += ShowRegistroGastosView;
            this.mainView.ShowComparacoesView += ShowComparacoesView;
        }

        #endregion

        #region Eventos

        private void ShowUsuariosView(object sender, EventArgs e)
        {
            IUsuarioView view = UsuarioView.GetInstance((Form)mainView);
            new UsuarioPresenter(usuarioLogado, view, stringConexao);
        }

        private void ShowCadastrosGastosView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = false;
            if (VerificarSeEhAdministradorOuSupervisor())
            {
                mainView.IsSuccessful = true;
                ICadastroGastosView view = CadastroGastosView.GetInstance((Form)mainView);
                new CadastroGastosPresenter(view, stringConexao);
            }
            else
            {
                mainView.Message = "O usuário logado não tem permissão para acessar os eletrodomésticos!";
            }
        }

        private void ShowRegistroGastosView(object sender, EventArgs e)
        {
            IRegistroGastosView view = RegistroGastosView.GetInstance((Form)mainView);
            new RegistroGastosPresenter(usuarioLogado, view, stringConexao);
        }

        private void ShowComparacoesView(object sender, EventArgs e)
        {

        }

        private bool VerificarSeEhAdministrador()
        {
            return usuarioLogado.TipoUsuario == Models.Common.Enums.TipoUsuario.Administrador;
        }

        private bool VerificarSeEhAdministradorOuSupervisor()
        {
            return VerificarSeEhAdministrador() ||
                   usuarioLogado.TipoUsuario == Models.Common.Enums.TipoUsuario.Supervisor;
        }

        #endregion

    }
}
