using System;
using CarbonTracker.Views;
using CarbonTracker.Models;
using CarbonTracker._Repositories;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class MainPresenter
    {

        #region Campos

        private readonly UsuariosModel usuarioLogado;
        private IMainView mainView;
        private readonly string stringConexao;

        #endregion

        #region Construtor

        public MainPresenter(UsuariosModel usuarioLogado, IMainView mainView, string stringConexao)
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
            this.mainView.ShowGrupoUsuariosView += ShowGrupoUsuariosView;
            this.mainView.ShowEletrodomesticoView += ShowEletrodomesticoView;
            this.mainView.ShowTransporteView += ShowTransporteView;
            this.mainView.ShowRegistroGastosView += ShowRegistroGastosView;
            this.mainView.ShowComparacoesView += ShowComparacoesView;
    }

        #endregion

        #region Eventos

        private void ShowUsuariosView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = false;
            if (VerificarSeEhAdministrador())
            {
                mainView.IsSuccessful = true;
                IUsuariosView view = UsuariosView.GetInstance((Form)mainView);
                IUsuariosRepository repository = new UsuariosRepository(stringConexao);
                new UsuariosPresenter(view, repository);
            }
            else 
            {
                mainView.Message = "O usuário logado não tem permissão para acessar os usuários!";
            }
        }      
        
        private void ShowGrupoUsuariosView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = false;
            if (VerificarSeEhAdministradorOuSupervisor())
            {
                mainView.IsSuccessful = true;
                IGrupoUsuariosView view = GrupoUsuariosView.GetInstance((Form)mainView);
                IGrupoUsuariosRepository repository = new GrupoUsuariosRepository(stringConexao);
                new GrupoUsuariosPresenter(view, repository);
            }
            else
            {
                mainView.Message = "O usuário logado não tem permissão para acessar os grupos de usuários!";
            }
        }

        private void ShowEletrodomesticoView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = false;
            if (VerificarSeEhAdministradorOuSupervisor())
            {
                mainView.IsSuccessful = true;
                IEletrodomesticoView view = EletrodomesticoView.GetInstance((Form)mainView);
                IEletrodomesticoRepository repository = new EletrodomesticoRepository(stringConexao);
                new EletrodomesticoPresenter(view, repository);
            }
            else
            {
                mainView.Message = "O usuário logado não tem permissão para acessar os eletrodomésticos!";
            }
        }

        private void ShowTransporteView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = false;
            if (VerificarSeEhAdministradorOuSupervisor())
            {
                mainView.IsSuccessful = true;
                ITransporteView view = TransporteView.GetInstance((Form)mainView);
                ITransporteRepository repository = new TransporteRepository(stringConexao);
                new TransportePresenter(view, repository);
            }
            else
            {
                mainView.Message = "O usuário logado não tem permissão para acessar os transportes!";
            }
        }

        private void ShowRegistroGastosView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = true;
        }

        private void ShowComparacoesView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = true;
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
