using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class CadastroGastosView : Form, ICadastroGastosView
    {

        #region Construtor

        public CadastroGastosView()
        {
            InitializeComponent();
            InicializaEventos();
            RemoveTodosTabPages();
        }

        #endregion

        #region Propriedades

        public TabPage TbpEletrodomestico { get => tbpEletrodomestico; }
        public TabPage TbpTransporte { get => tbpTransporte; }

        #endregion

        #region Eventos

        public event EventHandler ShowPreCadastroEletrodomesticoView;
        public event EventHandler ShowPreCadastroTransporteView;

        #endregion

        #region Métodos

        private void InicializaEventos()
        {
            btnEletrodomesticos.Click += delegate
            {
                ShowPreCadastroEletrodomesticoView?.Invoke(this, EventArgs.Empty);
                RemoveTodosTabPages();
                tbcRegistroGastos.TabPages.Add(tbpEletrodomestico);
            };

            btnTransporte.Click += delegate
            {
                ShowPreCadastroTransporteView?.Invoke(this, EventArgs.Empty);
                RemoveTodosTabPages();
                tbcRegistroGastos.TabPages.Add(tbpTransporte);
            };

            btnClose.Click += delegate { this.Close(); };
        }

        private void RemoveTodosTabPages()
        {
            foreach (TabPage tbp in tbcRegistroGastos.TabPages)
            {
                tbcRegistroGastos.TabPages.Remove(tbp);
            }
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static CadastroGastosView instance;

        public static CadastroGastosView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CadastroGastosView();
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
