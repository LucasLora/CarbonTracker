using System;

namespace CarbonTracker.Views
{
    public interface IAlterarInformacoesUsuarioLogado
    {

        #region Propriedades

        string UsuarioNome { get; set; }
        string UsuarioEmail { get; set; }
        string UsuarioSenha { get; set; }
        string UsuarioRepetirSenha { get; }

        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler SalvarEvent;

        #endregion

        #region Métodos

        void Show();

        #endregion

    }
}
