using CarbonTracker.Models;
using CarbonTracker.Services;
using CarbonTracker.Views;
using System;

namespace CarbonTracker.Presenters
{
    public class LoginPresenter
    {

        #region Campos

        private readonly ILoginView view;
        private readonly AutenticacaoService autenticacaoService;

        #endregion

        #region Propriedades

        public UsuariosModel UsuarioLogado { get { return autenticacaoService.UsuarioAutenticado; } }

        #endregion

        #region Construtor

        public LoginPresenter(ILoginView view, AutenticacaoService autenticacaoService)
        {
            this.view = view;
            this.autenticacaoService = autenticacaoService;

            VincularEventos();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.Entrar += Entrar;
        }

        private void Entrar(object sender, EventArgs e)
        {
            bool isAuthenticated = autenticacaoService.Autenticar(view.Usuario, view.Senha);
            if (isAuthenticated)
            {
                view.IsSuccessful = true;
            }
            else
            {
                view.IsSuccessful = false;
                view.Message = "Usuário ou senha inválidos.";
            }
        }

        #endregion

    }

}
