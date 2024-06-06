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
        TabPage TbpEntrarGrupoUsuarios { get; }

        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler ShowUsuario;
        event EventHandler ShowGrupoUsuarios;
        event EventHandler ShowAlterarInformacoesUsuarioLogado;
        event EventHandler ShowEntrarGrupo;

        #endregion

        #region Métodos

        void Show();

        #endregion

    }
}
