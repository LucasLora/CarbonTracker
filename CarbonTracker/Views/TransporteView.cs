using System;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Views
{
    public partial class TransporteView : Form, ITransporteView
    {

        #region Construtor

        public TransporteView()
        {
            InitializeComponent();
            InicializaEventos();
            this.tbcTransportes.TabPages.Remove(tbpDetalhes);
        }

        #endregion

        #region Propriedades

        public string TransporteId { get { return txtId.Text; } set { txtId.Text = value; } }
        public string TransporteNome { get { return txtNome.Text; } set { txtNome.Text = value; } }
        public TipoVeiculo TransporteTipoVeiculo
        {
            get { return (TipoVeiculo)(short)(cmbTipoVeiculo?.SelectedValue ?? 0); }
            set { cmbTipoVeiculo.SelectedValue = ((short)value).ToString(); }
        }
        public TipoCombustivel TransporteTipoCombustivel
        {
            get { return (TipoCombustivel)(short)(cmbTipoCombustivel?.SelectedValue ?? 0); }
            set { cmbTipoVeiculo.SelectedValue = ((short)value).ToString(); }
        }
        public string TransporteKmPorLitroCombustivel { get { return txtKmPorLitroCombustivel.Text; } set { txtKmPorLitroCombustivel.Text = value; } }

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
                tbcTransportes.TabPages.Remove(tbpListagem);
                tbcTransportes.TabPages.Add(tbpDetalhes);
                tbpDetalhes.Text = "Adicionar Transporte";
            };

            //Alterar
            btnAlterar.Click += delegate
            {
                AlterarEvent?.Invoke(this, EventArgs.Empty);
                tbcTransportes.TabPages.Remove(tbpListagem);
                tbcTransportes.TabPages.Add(tbpDetalhes);
                tbpDetalhes.Text = "Alterar Transporte";
            };

            //Excluir
            btnExcluir.Click += delegate
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o transporte selecionado?",
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
                    tbcTransportes.TabPages.Remove(tbpDetalhes);
                    tbcTransportes.TabPages.Add(tbpListagem);
                }
                MessageBox.Show(Message);
            };

            //Cancelar
            btnCancelar.Click += delegate
            {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                tbcTransportes.TabPages.Remove(tbpDetalhes);
                tbcTransportes.TabPages.Add(tbpListagem);
            };
        }

        public void SetTransporteListBindingSource(BindingSource eletrodomesticoList)
        {
            dgvTransportes.AutoGenerateColumns = false;
            dgvTransportes.DataSource = eletrodomesticoList;
        }

        public void SetComboBoxTipoVeiculoBindingSource(BindingSource tipoVeiculoList)
        {
            cmbTipoVeiculo.DataSource = tipoVeiculoList;
            cmbTipoVeiculo.DisplayMember = "Text";
            cmbTipoVeiculo.ValueMember = "Value";
        }

        public void SetComboBoxTipoCombustivelBindingSource(BindingSource tipoCombustivelList)
        {
            cmbTipoCombustivel.DataSource = tipoCombustivelList;
            cmbTipoCombustivel.DisplayMember = "Text";
            cmbTipoCombustivel.ValueMember = "Value";
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static TransporteView instance;

        public static TransporteView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TransporteView();
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
