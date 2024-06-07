using CarbonTracker.Models;
using CarbonTracker.Models.Models;
using CarbonTracker.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonTracker.Views.Views
{
    public partial class EntrarGrupoView : Form, IEntrarGrupoView
    {

        #region Construtor

        public EntrarGrupoView()
        {
            InitializeComponent();
            InicializaEventos();
        }

        #endregion

        #region Propriedades

        public string SearchValue { get { return this.txtProcurar.Text; } set { this.txtProcurar.Text = value; } }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler SearchEvent;
        public event EventHandler SalvarEvent;
        public event EventHandler RestaurarEvent;

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

        public void SetGrupoUsuariosListBindingSource(BindingSource grupoUsuariosList)
        {
            dgvEntrarGrupos.AutoGenerateColumns = false;
            dgvEntrarGrupos.DataSource = grupoUsuariosList;
        }

        #endregion

        #region Singleton pattern (Open a single form instance)

        private static EntrarGrupoView instance;

        public static EntrarGrupoView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EntrarGrupoView();
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
