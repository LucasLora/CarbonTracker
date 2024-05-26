using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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

        public string UsuariosNome { get => this.txtNome.Text; set => this.txtNome.Text = value; }
        public string UsuariosEmail { get => this.txtEmail.Text; set => this.txtEmail.Text = value; }
        public string UsuariosSenha { get => this.txtSenha.Text; set => this.txtSenha.Text = value; }
        public string UsuariosRepetirSenha { get => this.txtRepetirSenha.Text; }

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
                    Application.Exit(); //Fecha a aplicação, foi pedido antes se queria realmente prosseguir
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
