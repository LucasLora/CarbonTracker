using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class LoginView : Form, ILoginView
    {

        #region Construtor

        public LoginView()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            InicializaEventos();
        }

        #endregion

        #region Propriedades

        public string Usuario { get { return txtEmail.Text; } set { txtEmail.Text = value; } }
        public string Senha { get { return txtSenha.Text; } set { txtSenha.Text = value; } }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler Entrar;

        #endregion

        #region Métodos

        private void InicializaEventos()
        {
            //Fechar
            btnClose.Click += delegate { this.Close(); };

            //Logar
            btnEntrar.Click += delegate 
            {
                Entrar?.Invoke(this, EventArgs.Empty);
                VerificaSeLogou();
            };
            txtSenha.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Entrar?.Invoke(this, EventArgs.Empty);
                    VerificaSeLogou();
                }
            };  
        }

        private void VerificaSeLogou()
        {
            if (IsSuccessful)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
