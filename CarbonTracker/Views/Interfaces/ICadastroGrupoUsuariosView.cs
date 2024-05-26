using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public interface ICadastroGrupoUsuariosView
    {

        #region Propriedades

        string GrupoUsuariosId { get; set; }
        string GrupoUsuariosNome { get; set; }
        string GrupoUsuariosDescricao { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler SearchEvent;
        event EventHandler AdicionarEvent;
        event EventHandler AlterarEvent;
        event EventHandler ExcluirEvent;
        event EventHandler SalvarEvent;
        event EventHandler CancelarEvent;

        #endregion

        #region Métodos

        void SetGrupoUsuariosListBindingSource(BindingSource grupoUsuariosList);
        void Show();

        #endregion

    }
}
