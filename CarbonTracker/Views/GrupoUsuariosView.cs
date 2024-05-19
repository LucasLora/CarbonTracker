using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class GrupoUsuariosView : Form, IGrupoUsuariosView
    {
        #region Construtor

        public GrupoUsuariosView()
        {
            InitializeComponent();
            InicializaEventos();
            this.tbcGrupoUsuarios.TabPages.Remove(tbpDetalhes);
        }

        #endregion

        #region Propriedades

        public string GrupoUsuariosId { get { return txtId.Text; } set { txtId.Text = value; } }
        public string GrupoUsuariosNome { get { return txtNome.Text; } set { txtNome.Text = value; } }
        public string GrupoUsuariosDescricao { get { return txtDescricao.Text; } set { txtDescricao.Text = value; } }

        public string SearchValue { get { return txtProcurar.Text; } set { txtProcurar.Text = value; } }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler SearchEvent;
        public event EventHandler AdicionarEvent;
        public event EventHandler AlterarEvent;
        public event EventHandler ExcluirEvent;
        public event EventHandler SalvarEvent;
        public event EventHandler CancelarEvent;

        #endregion

        #region Métodos

        private void InicializaEventos()
        {
            //Fechar
            btnClose.Click += delegate { this.Close(); };

            //Procurar
            btnProcurar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtProcurar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            //Adicionar
            btnAdicionar.Click += delegate
            {
                AdicionarEvent?.Invoke(this, EventArgs.Empty);
                tbcGrupoUsuarios.TabPages.Remove(tbpListagem);
                tbcGrupoUsuarios.TabPages.Add(tbpDetalhes);
                tbpDetalhes.Text = "Adicionar Grupo Usuários";
            };

            //Alterar
            btnAlterar.Click += delegate
            {
                AlterarEvent?.Invoke(this, EventArgs.Empty);
                tbcGrupoUsuarios.TabPages.Remove(tbpListagem);
                tbcGrupoUsuarios.TabPages.Add(tbpDetalhes);
                tbpDetalhes.Text = "Alterar Grupo Usuários";
            };

            //Excluir
            btnExcluir.Click += delegate
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o grupo de usuários selecionado?",
                                    "Aviso",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ExcluirEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            //Salvar
            btnSalvar.Click += delegate
            {
                SalvarEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcGrupoUsuarios.TabPages.Remove(tbpDetalhes);
                    tbcGrupoUsuarios.TabPages.Add(tbpListagem);
                }
                MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
            };

            //Cancelar
            btnCancelar.Click += delegate
            {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                tbcGrupoUsuarios.TabPages.Remove(tbpDetalhes);
                tbcGrupoUsuarios.TabPages.Add(tbpListagem);
            };
        }

        public void SetGrupoUsuariosListBindingSource(BindingSource grupoUsuariosList)
        {
            dgvGrupoUsuarios.AutoGenerateColumns = false;
            dgvGrupoUsuarios.DataSource = grupoUsuariosList;
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static GrupoUsuariosView instance;

        public static GrupoUsuariosView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new GrupoUsuariosView();
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
