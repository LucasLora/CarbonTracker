using System;

namespace CarbonTracker.Views
{
    public interface ILoginView
    {

        #region Propriedades

        string Usuario { get; set; }
        string Senha { get; set; }

        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler Entrar;

        #endregion

    }

}
