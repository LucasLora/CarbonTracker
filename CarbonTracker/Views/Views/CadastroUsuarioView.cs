﻿using System;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Views
{
    public partial class CadastroUsuarioView : Form, ICadastroUsuarioView
    {

        #region Construtor

        public CadastroUsuarioView()
        {
            InitializeComponent();
            InicializaEventos();
            this.tbcUsuarios.TabPages.Remove(tbpDetalhes);
        }

        #endregion

        #region Propriedades

        public string UsuarioId { get { return txtId.Text; } set { txtId.Text = value; } }
        public string UsuarioNome { get { return txtNome.Text; } set { txtNome.Text = value; } }
        public TipoUsuario UsuarioTipoUsuario 
        {
            get { return (TipoUsuario)(short)(cmbTipoUsuario.SelectedValue ?? 0); }
            set { cmbTipoUsuario.SelectedValue = ((short)value).ToString(); } 
        }
        public string UsuarioEmail { get { return txtEmail.Text; } set { txtEmail.Text = value; } }
        public string UsuarioSenha { get { return txtSenha.Text; } set { txtSenha.Text = value; } }
        public string UsuarioDataCriacao { get { return txtDataCriacao.Text; } set { txtDataCriacao.Text = value; } }

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

        private void InicializaEventos()
        {
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
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
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
                MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
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
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = usuariosList;
        }

        public void SetComboBoxTipoUsuarioBindingSource(BindingSource tipoUsuarioList)
        {
            cmbTipoUsuario.DataSource = tipoUsuarioList;
            cmbTipoUsuario.DisplayMember = "Text";
            cmbTipoUsuario.ValueMember = "Value";
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static CadastroUsuarioView instance;

        public static CadastroUsuarioView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CadastroUsuarioView();
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
