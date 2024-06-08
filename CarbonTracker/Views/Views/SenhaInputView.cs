using CarbonTracker.Imagens.AjustaImagens;
using System.Drawing;
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
            CarregarERedimensionarImagemNoPanel();
            txtSenha.PasswordChar = '*';
            btnOk.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
            AcceptButton = btnOk;
            CancelButton = btnCancelar;
        }

        #endregion

        #region Métodos

        private void CarregarERedimensionarImagemNoPanel()
        {
            var redmencionarImagem = new AjustaImagens();
            Image imagemRedimensionada = redmencionarImagem.RedimensionarImagem(Properties.Resources.Carbon_Tracker_Reto, new Size(pnlImagem.Width, pnlImagem.Height));

            pnlImagem.BackgroundImage = imagemRedimensionada;
            pnlImagem.BackgroundImageLayout = ImageLayout.Stretch;
        }

        #endregion

    }
}
