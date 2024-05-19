using System;

namespace CarbonTracker.Views
{
    public interface IMainView
    {

        #region Eventos

        event EventHandler ShowUsuariosView;
        event EventHandler ShowGrupoUsuariosView;
        event EventHandler ShowEletrodomesticoView;
        event EventHandler ShowTransporteView;
        event EventHandler ShowRegistroGastosView;
        event EventHandler ShowComparacoesView;

        #endregion

    }
}
