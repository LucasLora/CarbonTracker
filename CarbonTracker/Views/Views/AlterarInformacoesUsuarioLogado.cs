using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class AlterarInformacoesUsuarioLogado : Form, IAlterarInformacoesUsuarioLogado
    {

        #region Construtor

        public AlterarInformacoesUsuarioLogado()
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

            //Cancelar
            btnCancelar.Click += delegate
            {
                this.Close();
            };
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static AlterarInformacoesUsuarioLogado instance;

        public static AlterarInformacoesUsuarioLogado GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AlterarInformacoesUsuarioLogado();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
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
