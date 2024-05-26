using CarbonTracker.Models;
using CarbonTracker.Presenters.Common;
using CarbonTracker.Views;
using System;

namespace CarbonTracker.Presenters
{
    public class AlterarInformacoesUsuarioLogadoPresenter
    {

        #region Campos

        private UsuariosModel usuarioLogado;
        private IAlterarInformacoesUsuarioLogado view;
        private IUsuariosRepository repository;

        #endregion

        #region Construtor

        public AlterarInformacoesUsuarioLogadoPresenter(UsuariosModel usuarioLogado, IAlterarInformacoesUsuarioLogado view, IUsuariosRepository repository)
        {
            this.usuarioLogado = usuarioLogado;
            this.view = view;
            this.repository = repository;

            VincularEventos();
            CarregarInformacoesUsuarioLogado();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.SalvarEvent += SalvarInformacoes;
        }

        #endregion

        #region Eventos

        private void CarregarInformacoesUsuarioLogado() 
        { 
            this.view.UsuariosNome = usuarioLogado.Nome;
            this.view.UsuariosEmail = usuarioLogado.Email;
            this.view.UsuariosSenha = usuarioLogado.Senha;
        }

        private void SalvarInformacoes(object sender, EventArgs e)
        {
            if (this.view.UsuariosSenha != this.view.UsuariosRepetirSenha)
            {
                view.IsSuccessful = false;
                view.Message = "Senhas não conferem!";
                return;
            }

            var model = (UsuariosModel)usuarioLogado.Clone();
            model.Nome = view.UsuariosNome.ToString();
            model.Email = view.UsuariosEmail.ToString();
            model.Senha = view.UsuariosSenha.ToString();

            try
            {
                new ModelDataValidation().Validate(model);
                
                repository.Alterar(model);

                view.Message = $"Informações alteradas com sucesso!{Environment.NewLine}A aplicação será finalizada!";
                view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        #endregion


    }
}
