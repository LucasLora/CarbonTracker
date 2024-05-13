using System;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Views
{
    public partial class UsuariosView : Form, IUsuariosView
    {

        #region Construtor

        public UsuariosView()
        {
            InitializeComponent();
            VincularEventos();
            this.tbcUsuarios.TabPages.Remove(tbpDetalhes);
        }

        #endregion

        #region Propriedades

        public string UsuariosId { get { return txtId.Text; } set { txtId.Text = value; } }
        public string UsuariosNome { get { return txtNome.Text; } set { txtNome.Text = value; } }
        public TipoUsuario UsuariosTipoUsuario { get { return (TipoUsuario)cmbTipoUsuario.SelectedValue; } set { cmbTipoUsuario.SelectedValue = value; } }
        public string UsuariosEmail { get { return txtEmail.Text; } set { txtEmail.Text = value; } }
        public string UsuariosSenha { get { return txtSenha.Text; } set { txtSenha.Text = value; } }
        public string UsuariosDataCriacao { get { return txtDataCriacao.Text; } set { txtDataCriacao.Text = value; } }
        public string SearchValue { get { return txtProcurar.Text; } set { txtProcurar.Text = value; } }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region  Eventos

        public event EventHandler SearchEvent;
        public event EventHandler AdicionarEvent;
        public event EventHandler AlterarEvent;
        public event EventHandler ExcluirEvent;
        public event EventHandler SalvarEvent;
        public event EventHandler CancelarEvent;

        #endregion

        #region Métodos

        private void VincularEventos()
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

            //Adcionar
            btnAdicionar.Click += delegate
            {
                AdicionarEvent?.Invoke(this, EventArgs.Empty);
                tbcUsuarios.TabPages.Remove(tbpListagem);
                tbcUsuarios.TabPages.Add(tbpDetalhes);
                tbpDetalhes.Text = "Adicionar Usuários";
            };

            //Alterar
            btnAlterar.Click += delegate
            {
                AlterarEvent?.Invoke(this, EventArgs.Empty);
                tbcUsuarios.TabPages.Remove(tbpListagem);
                tbcUsuarios.TabPages.Add(tbpDetalhes);
                tbpDetalhes.Text = "Alterar Usuários";
            };

            //Excluir
            btnExcluir.Click += delegate
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o Usuário selecionado?",
                                    "Aviso",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ExcluirEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            //Salvar
            btnSalvar.Click += delegate
            {
                SalvarEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbcUsuarios.TabPages.Remove(tbpDetalhes);
                    tbcUsuarios.TabPages.Add(tbpListagem);
                }
                MessageBox.Show(Message);
            };

            //Cancelar
            btnCancelar.Click += delegate
            {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                tbcUsuarios.TabPages.Remove(tbpDetalhes);
                tbcUsuarios.TabPages.Add(tbpListagem);
            };
        }

        public void SetUsuariosListBindingSource(BindingSource usuariosList)
        {
            dgvUsuarios.DataSource = usuariosList;
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static UsuariosView instance;
        public static UsuariosView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UsuariosView();
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
