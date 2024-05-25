using CarbonTracker.Models;
using System;
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
        }

        #endregion

        #region Propriedades

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        #endregion

        #region Eventos

        public event EventHandler ShowUsuariosView;
        public event EventHandler ShowGrupoUsuariosView;
        public event EventHandler ShowEletrodomesticoView;
        public event EventHandler ShowTransporteView;
        public event EventHandler ShowRegistroGastosView;
        public event EventHandler ShowComparacoesView;

        #endregion

        #region Métodos

        private void InicializaEventos()
        {
            //Abas
            btnUsuarios.Click += delegate
            {
                ShowUsuariosView?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnGrupoUsuarios.Click += delegate
            {
                ShowGrupoUsuariosView?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnEletrodomesticos.Click += delegate
            {
                ShowEletrodomesticoView?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnTransportes.Click += delegate
            {
                ShowTransporteView?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnRegistroGastos.Click += delegate
            {
                ShowRegistroGastosView?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            }; //Fazer o registro de gastos

            btnComparacoes.Click += delegate
            {
                ShowComparacoesView?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            }; //Fazer as comparações/relatórios

            btnClose.Click += delegate { this.Close(); };
        }

        #endregion

    }
}
