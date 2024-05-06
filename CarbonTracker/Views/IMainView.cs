using System;

namespace CarbonTracker.Views
{
    public interface IMainView
    {

        #region Eventos

        event EventHandler ShowEletrodomesticoView;
        event EventHandler ShowTransporteView;
        event EventHandler ShowUsuariosView;

        #endregion

    }
}
