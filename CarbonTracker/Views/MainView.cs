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
        public event EventHandler ShowPreCadastrosGastosView;
        public event EventHandler ShowAlterarInformacoesView;
        public event EventHandler ShowRegistroGastosView;
        public event EventHandler ShowComparacoesView;

        #endregion

        #region Métodos

        private void InicializaEventos()
        {
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

            btnPreCadastrosGastos.Click += delegate
            {
                ShowPreCadastrosGastosView?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                {
                    MessageBox.Show(Message, "Carbon Tracker", MessageBoxButtons.OK);
                }
            };

            btnAlterarInformacoes.Click += delegate
            {
                if (MessageBox.Show($"Será necessário reiniciar após alterar as informações!{Environment.NewLine}Tem certeza que deseja prosseguir? ",
                                     "Aviso",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ShowAlterarInformacoesView?.Invoke(this, EventArgs.Empty);
                }
                
            };

            btnRegistroGastos.Click += delegate
            {
                ShowRegistroGastosView?.Invoke(this, EventArgs.Empty);
            };

            btnComparacoes.Click += delegate
            {
                ShowComparacoesView?.Invoke(this, EventArgs.Empty);
            };

            btnClose.Click += delegate 
            {
                if (MessageBox.Show("Você tem certeza que deseja sair?", 
                                    "Confirmação", 
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };
        }

        #endregion

    }
}
