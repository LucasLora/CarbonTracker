using CarbonTracker.Models;
using CarbonTracker.Presenters.Common;
using CarbonTracker.Views;
using System;

namespace CarbonTracker.Presenters
{
    public class AlterarInformacoesUsuarioLogadoPresenter
    {

        #region Campos

        private UsuarioModel usuarioLogado;
        private IAlterarInformacoesUsuarioLogado view;
        private IUsuariosRepository repository;

        #endregion

        #region Construtor

        public AlterarInformacoesUsuarioLogadoPresenter(UsuarioModel usuarioLogado, IAlterarInformacoesUsuarioLogado view, IUsuariosRepository repository)
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
            this.view.UsuarioNome = usuarioLogado.Nome;
            this.view.UsuarioEmail = usuarioLogado.Email;
            this.view.UsuarioSenha = usuarioLogado.Senha;
        }

        private void SalvarInformacoes(object sender, EventArgs e)
        {
            try
            {
                if (this.view.UsuarioSenha != this.view.UsuarioRepetirSenha)
                {
                    throw new Exception("Senhas não conferem!");
                }

                var model = (UsuarioModel)usuarioLogado.Clone();
                model.Nome = view.UsuarioNome.ToString();
                model.Email = view.UsuarioEmail.ToString();
                model.Senha = view.UsuarioSenha.ToString();

                new ModelDataValidation().Validate(model);
                
                repository.Alterar(model);

                view.IsSuccessful = true;
                view.Message = $"Informações alteradas com sucesso!{Environment.NewLine}A aplicação será finalizada!";
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
