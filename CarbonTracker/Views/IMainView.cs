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
        event EventHandler ShowGrupoUsuariosView;
        event EventHandler ShowPreCadastrosGastosView;
        event EventHandler ShowRegistroGastosView;
        event EventHandler ShowComparacoesView;
        event EventHandler ShowAlterarInformacoesView;

        #endregion

    }
}
