﻿using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public partial class CadastroEletrodomesticoView : Form, ICadastroEletrodomesticoView
    {

        #region Construtor

        public CadastroEletrodomesticoView()
        {
            InitializeComponent();
            InicializaEventos();
            this.tbcEletrodomesticos.TabPages.Remove(tbpDetalhes);
        }

        #endregion

        #region Propriedades

        public string EletrodomesticoId { get { return txtId.Text; } set { txtId.Text = value; } }
        public string EletrodomesticoNome { get { return txtNome.Text; } set { txtNome.Text = value; } }
        public string EletrodomesticoLitroPorHoraAgua { get { return txtLitroPorHoraAgua.Text; } set { txtLitroPorHoraAgua.Text = value; } }
        public string EletrodomesticoKWPorHoraEletricidade { get { return txtKwPorHoraEletricidade.Text; } set { txtKwPorHoraEletricidade.Text = value; } }

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
                tbcEletrodomesticos.TabPages.Remove(tbpListagem);
                tbcEletrodomesticos.TabPages.Add(tbpDetalhes);
                tbpDetalhes.Text = "Adicionar Eletrodoméstico";
            };

            //Alterar
            btnAlterar.Click += delegate
            {
                AlterarEvent?.Invoke(this, EventArgs.Empty);
                tbcEletrodomesticos.TabPages.Remove(tbpListagem);
                tbcEletrodomesticos.TabPages.Add(tbpDetalhes);
                tbpDetalhes.Text = "Alterar Eletrodoméstico";
            };

            //Excluir
            btnExcluir.Click += delegate
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o eletrodoméstico selecionado?",
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
                    tbcEletrodomesticos.TabPages.Remove(tbpDetalhes);
                    tbcEletrodomesticos.TabPages.Add(tbpListagem);
                }
                MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
            };

            //Cancelar
            btnCancelar.Click += delegate
            {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                tbcEletrodomesticos.TabPages.Remove(tbpDetalhes);
                tbcEletrodomesticos.TabPages.Add(tbpListagem);
            };
        }

        public void SetEletrodomesticoListBindingSource(BindingSource transporteList)
        {
            dgvEletrodomesticos.AutoGenerateColumns = false;
            dgvEletrodomesticos.DataSource = transporteList;
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static CadastroEletrodomesticoView instance;

        public static CadastroEletrodomesticoView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CadastroEletrodomesticoView();
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
