using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class SenhaInputView : Form
    {

        public string Password => txtSenha.Text;

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

    }
}
