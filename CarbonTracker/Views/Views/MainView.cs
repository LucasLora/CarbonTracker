using CarbonTracker.Imagens.AjustaImagens;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class MainView : Form, IMainView
    {

        #region Construtor

        public MainView()
        {
            InitializeComponent();
            InicializaEventos();
            CarregarERedimensionarImagemNoPanel();
        }

        #endregion

        #region Propriedades

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler ShowUsuariosView;
        public event EventHandler ShowCadastrosGastosView;
        public event EventHandler ShowRegistroGastosView;
        public event EventHandler ShowComparacoesView;

        #endregion

        #region Métodos

        private void CarregarERedimensionarImagemNoPanel()
        {
            // Carregar a imagem dos recursos embutidos
            Image imagemOriginal = Properties.Resources.Carbon_TrackerLogo; // Substitua pelo nome do recurso da sua imagem

            // Redimensionar a imagem
            var redmencionarImagem = new AjustaImagens();
            Image imagemRedimensionada = redmencionarImagem.RedimensionarImagem(imagemOriginal, new Size(panelLogoMain.Width, panelLogoMain.Height));

            // Definir a imagem redimensionada como plano de fundo do Panel
            panelLogoMain.BackgroundImage = imagemRedimensionada;
            panelLogoMain.BackgroundImageLayout = ImageLayout.Stretch; // Ajusta a imagem para preencher o Panel
        }

        private void InicializaEventos()
        {
            btnUsuarios.Click += delegate
            {
                ShowUsuariosView?.Invoke(this, EventArgs.Empty);
            };

            btnCadastrosGastos.Click += delegate
            {
                ShowCadastrosGastosView?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnRegistroGastos.Click += delegate
            {
                ShowRegistroGastosView?.Invoke(this, EventArgs.Empty);
            };

            btnComparacoes.Click += delegate
            {
                ShowComparacoesView?.Invoke(this, EventArgs.Empty);
            };

            btnClose.Click += delegate 
            {
                if (MessageBox.Show("Você tem certeza que deseja sair?", 
                                    "Confirmação", 
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };
        }

        #endregion

    }
}
