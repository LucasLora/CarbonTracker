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

        #region Eventos

        public event EventHandler ShowEletrodomesticoView;
        public event EventHandler ShowTransporteView;
        public event EventHandler ShowUsuariosView;

        #endregion

        #region Métodos

        private void InicializaEventos()
        {
            //Abas
            btnEletrodomesticos.Click += delegate { ShowEletrodomesticoView?.Invoke(this, EventArgs.Empty); };
            btnTransportes.Click += delegate { ShowTransporteView?.Invoke(this, EventArgs.Empty); };
            btnUsuarios.Click += delegate { ShowUsuariosView?.Invoke(this, EventArgs.Empty); };
        }

        #endregion

    }
}
