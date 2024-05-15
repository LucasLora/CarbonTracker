using System;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Views
{
    public interface IUsuariosView
    {

        #region Propriedades

        string UsuariosId { get; set; }
        string UsuariosNome { get; set; }
        string UsuariosEmail { get; set; }
        string UsuariosSenha { get; set; }
        TipoUsuario UsuariosTipoUsuario { get; set; }
        string UsuariosDataCriacao { get; set; }

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

        void SetUsuariosListBindingSource(BindingSource usuariosList);
        void SetComboBoxTipoUsuarioBindingSource(BindingSource tipoUsuarioList);
        void Show();

        #endregion

    }
}
