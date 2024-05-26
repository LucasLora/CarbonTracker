using CarbonTracker._Repositories;
using CarbonTracker.Models;
using CarbonTracker.Views;
using CarbonTracker.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class UsuarioPresenter
    {

        #region Campos

        private readonly UsuarioModel usuarioLogado;
        private IUsuarioView view;
        private readonly string stringConexao;

        #endregion

        #region Construtor

        public UsuarioPresenter(UsuarioModel usuarioLogado, IUsuarioView view, string stringConexao)
        {
            this.usuarioLogado = usuarioLogado;
            this.view = view;
            this.stringConexao = stringConexao;

            VincularEventos();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.ShowUsuario += ShowUsuario;
            this.view.ShowGrupoUsuarios += ShowGrupoUsuarios;
            this.view.ShowAlterarInformacoesUsuarioLogado += ShowAlterarInformacoesUsuarioLogado;
        }

        #endregion

        #region Eventos

        private void ShowUsuario(object sender, EventArgs e)
        {
            view.IsSuccessful = false;
            if (VerificarSeEhAdministradorOuSupervisor())
            {
                this.view.IsSuccessful = true;
                ICadastroUsuarioView viewCadastroUsuario = CadastroUsuarioView.GetInstance();
                IUsuariosRepository repository = new UsuariosRepository(stringConexao);
                new CadastroUsuarioPresenter(usuarioLogado, viewCadastroUsuario, repository);              

                //Vincula a view ao TabPage
                var viewCadastroUsuarioControl = (Control)viewCadastroUsuario;
                viewCadastroUsuarioControl.Dock = DockStyle.Fill;
                view.TbpUsuario.Controls.Clear();
                view.TbpUsuario.Controls.Add(viewCadastroUsuarioControl);
            }
            else
            {
                view.Message = "O usuário logado não tem permissão para acessar os usuários!";
            }
        }

        private void ShowGrupoUsuarios(object sender, EventArgs e)
        {
            view.IsSuccessful = false;
            if (VerificarSeEhAdministradorOuSupervisor())
            {
                this.view.IsSuccessful = true;
                ICadastroGrupoUsuariosView viewCadastroGrupoUsuarios = CadastroGrupoUsuariosView.GetInstance();
                IGrupoUsuariosRepository repository = new GrupoUsuariosRepository(stringConexao);
                new CadastroGrupoUsuariosPresenter(viewCadastroGrupoUsuarios, repository);

                //Vincula a view ao TabPage
                var viewCadastroGrupoUsuariosControl = (Control)viewCadastroGrupoUsuarios;
                viewCadastroGrupoUsuariosControl.Dock = DockStyle.Fill;
                view.TbpGrupoUsuarios.Controls.Clear();
                view.TbpGrupoUsuarios.Controls.Add(viewCadastroGrupoUsuariosControl);
            }
            else
            {
                view.Message = "O usuário logado não tem permissão para acessar os grupos de usuários!";
            }
        }

        private void ShowAlterarInformacoesUsuarioLogado(object sender, EventArgs e)
        {
            using (var passwordForm = new SenhaInputView())
            {
                view.IsSuccessful = false;

                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    //Verifica se a senha inserida corresponde à senha do usuário atual
                    if (usuarioLogado.Senha == passwordForm.Password)
                    {
                        this.view.IsSuccessful = true;
                        IAlterarInformacoesUsuarioLogadoView viewAlterarInformacoesUsuarioLogado = AlterarInformacoesUsuarioLogadoView.GetInstance();
                        IUsuariosRepository repository = new UsuariosRepository(stringConexao);
                        new AlterarInformacoesUsuarioLogadoPresenter(usuarioLogado, viewAlterarInformacoesUsuarioLogado, repository);

                        //Vincula a view ao TabPage
                        var viewAlterarInformacoesUsuarioLogadoControl = (Control)viewAlterarInformacoesUsuarioLogado;
                        viewAlterarInformacoesUsuarioLogadoControl.Dock = DockStyle.Fill;
                        view.TbpAlterarInformacoesUsuarioLogado.Controls.Clear();
                        view.TbpAlterarInformacoesUsuarioLogado.Controls.Add(viewAlterarInformacoesUsuarioLogadoControl);
                    }
                    else
                    {
                        view.Message = "Senha incorreta!";
                    }
                }
                else
                {
                    view.Message = "Operação cancelada!";
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
