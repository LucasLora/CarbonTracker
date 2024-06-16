using CarbonTracker.Imagens.AjustaImagens;
using CarbonTracker.Views.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarbonTracker.Views.Views
{
    public partial class ComparacoesView : Form, IComparacoesView
    {

        #region Construtor

        public ComparacoesView()
        {
            InitializeComponent();
            CarregarERedimensionarImagemNoPanel();      
            InicializaEventos();
        }

        #endregion

        #region Propriedades

        public DateTime DiaInicial { get { return this.dtpDiaInicial.Value.Date; } set { this.dtpDiaInicial.Value = value; } }
        public DateTime DiaFinal { get { return this.dtpDiaFinal.Value.Date; } set { this.dtpDiaFinal.Value = value; } }
        public bool CompararGrupos { get { return this.chkCompararGrupos.Checked; } set { this.chkCompararGrupos.Checked = value; } }
        public string Pontuacao { get { return this.txtPontuacao.Text; } set { this.txtPontuacao.Text = value; } }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler CompararEvent;
        public event EventHandler MensalEvent;
        public event EventHandler TrimestralEvent;
        public event EventHandler SemestralEvent;
        public event EventHandler AnualEvent;

        #endregion

        #region Métodos

        private void CarregarERedimensionarImagemNoPanel()
        {
            Image imagemOriginal = Properties.Resources.Comparacoes;

            var redmencionarImagem = new AjustaImagens();
            Image imagemRedimensionada = redmencionarImagem.RedimensionarImagem(imagemOriginal, new Size(panelComparacoes.Width, panelComparacoes.Height));

            panelComparacoes.BackgroundImage = imagemRedimensionada;
            panelComparacoes.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InicializaEventos()
        {
            //Comparar
            btnComparar.Click += delegate
            {
                CompararEvent?.Invoke(this, EventArgs.Empty);
                if (!this.IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            //Mensal
            btnMensal.Click += delegate { MensalEvent.Invoke(this, EventArgs.Empty); };

            //Trimestral
            btnTrimestral.Click += delegate { TrimestralEvent.Invoke(this, EventArgs.Empty); };

            //Semestral
            btnSemestral.Click += delegate { SemestralEvent.Invoke(this, EventArgs.Empty); };

            //Anual
            btnAnual.Click += delegate { AnualEvent.Invoke(this, EventArgs.Empty); };

            //Fechar
            btnClose.Click += delegate { this.Close(); };
        }

        public void BloquearBotoes(bool bloquear)
        {
            btnComparar.Enabled = !bloquear;
            btnMensal.Enabled = !bloquear;
            btnTrimestral.Enabled = !bloquear;
            btnSemestral.Enabled = !bloquear;
            btnAnual.Enabled = !bloquear;
        }

        public void SetPosicaoGruposUsuariosListBindingSource(BindingSource posicaoGruposUsuarios)
        {
            dgvPosicaoGruposUsuarios.AutoGenerateColumns = false;
            dgvPosicaoGruposUsuarios.DataSource = posicaoGruposUsuarios;
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static ComparacoesView instance;

        public static ComparacoesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ComparacoesView();
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
