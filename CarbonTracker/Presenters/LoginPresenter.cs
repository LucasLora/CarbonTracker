﻿using CarbonTracker.Models;
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

        public UsuarioModel UsuarioLogado { get { return autenticacaoService.UsuarioAutenticado; } }

        #endregion

        #region Construtor

        public LoginPresenter(ILoginView view, AutenticacaoService autenticacaoService, string usuarioPadrao = null, string senhaPadrao = null)
        {
            this.view = view;
            this.autenticacaoService = autenticacaoService;

            ValoresPadrao(usuarioPadrao, senhaPadrao);
            VincularEventos();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.Entrar += Entrar;
        }

        private void ValoresPadrao(string usuario, string senha)
        {
            view.Usuario = usuario ?? "";
            view.Senha = senha ?? "";
        }

        private void Entrar(object sender, EventArgs e)
        {
            bool isAuthenticated = autenticacaoService.Autenticar(view.Usuario, view.Senha);
            if (isAuthenticated)
            {
                view.IsSuccessful = true;
                view.Message = "Usuário autenticado com sucesso.";
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
