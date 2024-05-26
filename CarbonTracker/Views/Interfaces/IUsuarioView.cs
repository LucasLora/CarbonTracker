using System;
using System.Windows.Forms;

namespace CarbonTracker.Views.Interfaces
{
    public interface IUsuarioView
    {

        #region Propriedades

        TabPage TbpUsuario { get; }
        TabPage TbpGrupoUsuarios { get; }
        TabPage TbpAlterarInformacoesUsuarioLogado { get; }


        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler ShowUsuario;
        event EventHandler ShowGrupoUsuarios;
        event EventHandler ShowAlterarInformacoesUsuarioLogado;

        #endregion

        #region Métodos

        void Show();

        #endregion

    }
}
