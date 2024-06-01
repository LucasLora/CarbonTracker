using CarbonTracker.Imagens.AjustaImagens;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class RegistroGastosView : Form, IRegistroGastosView
    {

        #region Construtor

        public RegistroGastosView()
        {
            InitializeComponent();
            InicializaEventos();
            RemoveTodosTabPages();
            CarregarERedimensionarImagemNoPanel();
        }

        #endregion

        #region Propriedades

        public TabPage TbpEletrodomestico { get => tbpEletrodomestico; }
        public TabPage TbpTransporte { get => tbpTransporte; }

        #endregion

        #region Eventos

        public event EventHandler ShowGastosEletrodomesticoView;
        public event EventHandler ShowGastosTransporteView;

        #endregion

        #region Métodos

        private void CarregarERedimensionarImagemNoPanel()
        {
            // Carregar a imagem dos recursos embutidos
            Image imagemOriginal = Properties.Resources.Registro_De_Gastos; // Substitua pelo nome do recurso da sua imagem

            // Redimensionar a imagem
            var redmencionarImagem = new AjustaImagens();
            Image imagemRedimensionada = redmencionarImagem.RedimensionarImagem(imagemOriginal, new Size(panelRegistroGastos.Width, panelRegistroGastos.Height));

            // Definir a imagem redimensionada como plano de fundo do Panel
            panelRegistroGastos.BackgroundImage = imagemRedimensionada;
            panelRegistroGastos.BackgroundImageLayout = ImageLayout.Stretch; // Ajusta a imagem para preencher o Panel
        }

        private void InicializaEventos()
        {
            btnEletrodomesticos.Click += delegate 
            { 
                ShowGastosEletrodomesticoView?.Invoke(this, EventArgs.Empty);
                RemoveTodosTabPages();
                tbcRegistroGastos.TabPages.Add(tbpEletrodomestico);
            };

            btnTransporte.Click += delegate 
            {
                ShowGastosTransporteView?.Invoke(this, EventArgs.Empty);
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

        private static RegistroGastosView instance;

        public static RegistroGastosView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegistroGastosView();
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
