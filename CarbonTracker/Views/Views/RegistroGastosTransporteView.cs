using CarbonTracker.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace CarbonTracker.Views.Views
{
    public partial class RegistroGastosTransporteView : Form, IRegistroGastosTransporteView
    {

        #region Construtor

        public RegistroGastosTransporteView()
        {
            InitializeComponent();
            InicializaEventos();
            BloquearDiaEDesbloquearRegistro(false);
        }

        #endregion

        #region Propriedades

        public DateTime Dia { get { return this.dtpDia.Value.Date; } set { this.dtpDia.Value = value; } }
        public string SearchValue { get { return this.txtPesquisar.Text; } set { this.txtPesquisar.Text = value; } }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler RegistrarDia;
        public event EventHandler TrocarDia;
        public event EventHandler SearchEvent;
        public event EventHandler SalvarEvent;
        public event EventHandler RestaurarEvent;

        #endregion

        #region Métodos

        private void InicializaEventos()
        {
            //Registrar
            btnRegistrar.Click += delegate
            {
                RegistrarDia?.Invoke(this, EventArgs.Empty);
            };

            //Trocar Dia
            btnTrocar.Click += delegate
            {
                if (MessageBox.Show($"Trocar o dia sem salvar irá perder as atualizações feitas nos registro!{Environment.NewLine}Deseja continuar? ",
                                      "Aviso",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TrocarDia?.Invoke(this, EventArgs.Empty);
                }
            };

            //Procurar
            btnPesquisar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtPesquisar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            //Salvar
            btnSalvar.Click += delegate
            {
                SalvarEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {

                }
                MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
            };

            //Restaurar
            btnRestaurar.Click += delegate
            {
                RestaurarEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public void SetGastosTransporteListBindingSource(BindingSource gastosEletrodomesticoList)
        {
            dgvRegistros.AutoGenerateColumns = false;
            dgvRegistros.DataSource = gastosEletrodomesticoList;
        }

        public void BloquearDiaEDesbloquearRegistro(bool bloquear)
        {
            this.lblDia.Enabled = !bloquear;
            this.dtpDia.Enabled = !bloquear;
            this.btnRegistrar.Enabled = !bloquear;
            this.btnTrocar.Enabled = bloquear;
            this.lblPesquisar.Enabled = bloquear;
            this.txtPesquisar.Enabled = bloquear;
            this.btnPesquisar.Enabled = bloquear;
            this.dgvRegistros.Enabled = bloquear;
            this.btnSalvar.Enabled = bloquear;
            this.btnRestaurar.Enabled = bloquear;
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static RegistroGastosTransporteView instance;

        public static RegistroGastosTransporteView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegistroGastosTransporteView();
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
