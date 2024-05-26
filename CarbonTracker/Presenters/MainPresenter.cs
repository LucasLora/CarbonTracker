using System;
using CarbonTracker.Views;
using CarbonTracker.Models;
using CarbonTracker._Repositories;
using System.Windows.Forms;
using CarbonTracker.Services;

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
            this.mainView.ShowPreCadastrosGastosView += ShowPreCadastrosGastosView;
            this.mainView.ShowRegistroGastosView += ShowRegistroGastosView;
            this.mainView.ShowComparacoesView += ShowComparacoesView;
            this.mainView.ShowAlterarInformacoesView += ShowAlterarInformacoesView;
        }

        #endregion

        #region Eventos

        private void ShowUsuariosView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = false;
            if (VerificarSeEhAdministradorOuSupervisor())
            {
                mainView.IsSuccessful = true;
                IUsuariosView view = UsuariosView.GetInstance((Form)mainView);
                IUsuariosRepository repository = new UsuariosRepository(stringConexao);
                new UsuariosPresenter(usuarioLogado, view, repository);
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

        private void ShowPreCadastrosGastosView(object sender, EventArgs e)
        {
            mainView.IsSuccessful = false;
            if (VerificarSeEhAdministradorOuSupervisor())
            {
                mainView.IsSuccessful = true;
                IPreCadastroGastosView view = PreCadastroGastosView.GetInstance((Form)mainView);
                new PreCadastroGastosPresenter(view, stringConexao);
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

        private void ShowAlterarInformacoesView(object sender, EventArgs e)
        {
            using (var passwordForm = new SenhaInputView())
            {
                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    string inputPassword = passwordForm.Password;

                    //Verifica se a senha inserida corresponde à senha do usuário atual
                    if (usuarioLogado.Senha == inputPassword)
                    {
                        IAlterarInformacoesUsuarioLogado view = AlterarInformacoesUsuarioLogado.GetInstance((Form)mainView);
                        IUsuariosRepository repository = new UsuariosRepository(stringConexao);
                        new AlterarInformacoesUsuarioLogadoPresenter(usuarioLogado, view, repository);
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }     
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
