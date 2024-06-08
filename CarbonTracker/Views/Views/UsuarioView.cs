using CarbonTracker.Imagens.AjustaImagens;
using CarbonTracker.Views.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarbonTracker.Views.Views
{
    public partial class UsuarioView : Form, IUsuarioView
    {

        #region Construtor

        public UsuarioView()
        {
            InitializeComponent();
            InicializaEventos();
            RemoveTodosTabPages();
            CarregarERedimensionarImagemNoPanel();
        }

        #endregion

        #region Propriedades

        public TabPage TbpUsuario { get => tbpUsuario; }
        public TabPage TbpGrupoUsuarios { get => tbpGrupoUsuarios; }
        public TabPage TbpAlterarInformacoesUsuarioLogado { get => tbpAlterarInformacoes; }
        public TabPage TbpEntrarGrupoUsuarios { get => tbpEntrarGrupo; }


        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler ShowUsuario;
        public event EventHandler ShowGrupoUsuarios;
        public event EventHandler ShowAlterarInformacoesUsuarioLogado;
        public event EventHandler ShowEntrarGrupo;

        #endregion

        #region Métodos

        private void CarregarERedimensionarImagemNoPanel()
        {
            Image imagemOriginal = Properties.Resources.Informaoes_De_Usuarios;

            var redmencionarImagem = new AjustaImagens();
            Image imagemRedimensionada = redmencionarImagem.RedimensionarImagem(imagemOriginal, new Size(panelUsuarios.Width, panelUsuarios.Height));

            panelUsuarios.BackgroundImage = imagemRedimensionada;
            panelUsuarios.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void InicializaEventos()
        {
            btnUsuario.Click += delegate
            {              
                ShowUsuario?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    RemoveTodosTabPages();
                    tbcUsuario.TabPages.Add(tbpUsuario);
                }
                else
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnGrupoUsuarios.Click += delegate
            {
                ShowGrupoUsuarios?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    RemoveTodosTabPages();
                    tbcUsuario.TabPages.Add(tbpGrupoUsuarios);
                }
                else
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnAlterarInformacoesUsuarioLogado.Click += delegate
            {
                if (MessageBox.Show($"Será necessário reiniciar após alterar as informações!{Environment.NewLine}Tem certeza que deseja prosseguir? ",
                                      "Aviso",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ShowAlterarInformacoesUsuarioLogado?.Invoke(this, EventArgs.Empty);

                    if (IsSuccessful)
                    {
                        RemoveTodosTabPages();
                        tbcUsuario.TabPages.Add(tbpAlterarInformacoes);
                    }
                    else
                    {
                        MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                    }
                }
            };

            btnEntrarGrupo.Click += delegate
            {
                ShowEntrarGrupo?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    RemoveTodosTabPages();
                    tbcUsuario.TabPages.Add(tbpEntrarGrupo);
                }
                else
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnClose.Click += delegate { this.Close(); };
        }

        private void RemoveTodosTabPages()
        {
            foreach (TabPage tbp in tbcUsuario.TabPages)
            {
                tbcUsuario.TabPages.Remove(tbp);
            }
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static UsuarioView instance;

        public static UsuarioView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UsuarioView();
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
