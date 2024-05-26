using System;

namespace CarbonTracker.Views
{
    public interface IMainView
    {

        #region Propriedades

        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler ShowUsuariosView;
        event EventHandler ShowCadastrosGastosView;
        event EventHandler ShowRegistroGastosView;
        event EventHandler ShowComparacoesView;

        #endregion

    }
}
