﻿using System;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Views
{
    public partial class CadastroTransporteView : Form, ICadastroTransporteView
    {

        #region Construtor

        public CadastroTransporteView()
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
            get 
            { 
                if (cmbTipoVeiculo.SelectedValue == null)
                {
                    return TipoVeiculo.Carro;
                }
                else
                {
                    return (TipoVeiculo)(short)cmbTipoVeiculo.SelectedValue; 
                }
            }
            set 
            { 
                cmbTipoVeiculo.SelectedValue = ((short)value).ToString(); 
            }
        }
        public TipoCombustivel TransporteTipoCombustivel
        {
            get 
            { 
                if (cmbTipoCombustivel.SelectedValue == null)
                { 
                    return TipoCombustivel.NaoAplica; 
                }
                else
                {
                    return (TipoCombustivel)(short)cmbTipoCombustivel.SelectedValue; 
                }
            }
            set 
            {
                cmbTipoCombustivel.SelectedValue = ((short)value).ToString(); 
            }
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
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
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
                MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
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

        private static CadastroTransporteView instance;

        public static CadastroTransporteView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CadastroTransporteView();
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
