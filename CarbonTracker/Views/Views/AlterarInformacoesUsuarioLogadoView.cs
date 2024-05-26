using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class AlterarInformacoesUsuarioLogadoView : Form, IAlterarInformacoesUsuarioLogadoView
    {

        #region Construtor

        public AlterarInformacoesUsuarioLogadoView()
        {
            InitializeComponent();
            InicializaEventos();
        }

        #endregion

        #region Propriedades

        public string UsuarioNome { get => this.txtNome.Text; set => this.txtNome.Text = value; }
        public string UsuarioEmail { get => this.txtEmail.Text; set => this.txtEmail.Text = value; }
        public string UsuarioSenha { get => this.txtSenha.Text; set => this.txtSenha.Text = value; }
        public string UsuarioRepetirSenha { get => this.txtRepetirSenha.Text; }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler SalvarEvent;

        #endregion

        #region Métodos

        private void InicializaEventos()
        {
            //Salvar
            btnSalvar.Click += delegate
            {
                SalvarEvent?.Invoke(this, EventArgs.Empty);

                MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);

                if (IsSuccessful)
                {
                    Application.Exit(); //Fecha toda a aplicação, foi pedido antes se queria realmente prosseguir
                }
            };
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static AlterarInformacoesUsuarioLogadoView instance;

        public static AlterarInformacoesUsuarioLogadoView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AlterarInformacoesUsuarioLogadoView();
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                instance.TopLevel = false;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        #endregion

    }
}
