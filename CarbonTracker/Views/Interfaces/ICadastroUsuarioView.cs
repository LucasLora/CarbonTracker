using System;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Views
{
    public interface ICadastroUsuarioView
    {

        #region Propriedades

        string UsuarioId { get; set; }
        string UsuarioNome { get; set; }
        string UsuarioEmail { get; set; }
        string UsuarioSenha { get; set; }
        TipoUsuario UsuarioTipoUsuario { get; set; }
        string UsuarioDataCriacao { get; set; }

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
