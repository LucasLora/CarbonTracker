using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class SenhaInputView : Form
    {

        #region Propriedades

        public string Password => txtSenha.Text;

        #endregion

        #region Construtor

        public SenhaInputView()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            txtSenha.PasswordChar = '*';
            btnOk.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
            AcceptButton = btnOk;
            CancelButton = btnCancelar;
        }

        #endregion

    }
}
