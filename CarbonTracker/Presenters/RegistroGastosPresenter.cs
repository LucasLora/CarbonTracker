using CarbonTracker._Repositories;
using CarbonTracker.Models;
using CarbonTracker.Models.RepositoriesInterfaces;
using CarbonTracker.Views;
using CarbonTracker.Views.Interfaces;
using CarbonTracker.Views.Views;
using System;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class RegistroGastosPresenter
    {

        #region Campos

        private readonly UsuarioModel usuarioLogado;
        private IRegistroGastosView view;
        private readonly string stringConexao;

        #endregion

        #region Construtor

        public RegistroGastosPresenter(UsuarioModel usuarioLogado, IRegistroGastosView mainView, string stringConexao)
        {
            this.usuarioLogado = usuarioLogado;
            this.view = mainView;
            this.stringConexao = stringConexao;
            
            VincularEventos();
            
            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.ShowGastosEletrodomesticoView += ShowGastosEletrodomesticoView;
            this.view.ShowGastosTransporteView += ShowGastosTransporteView;
        }

        #endregion

        #region Eventos

        private void ShowGastosEletrodomesticoView(object sender, EventArgs e)
        {
            IRegistroGastosEletrodomesticoView view = RegistroGastosEletrodomesticoView.GetInstance();
            IGastosEletrodomesticoRepository repository = new GastosEletrodomesticoRepository(stringConexao);
            new RegistroGastosEletrodomesticoPresenter(usuarioLogado, view, repository);

            //Vincula a view ao TabPage
            var control = (Control)view;
            control.Dock = DockStyle.Fill;
            this.view.TbpEletrodomestico.Controls.Clear();
            this.view.TbpEletrodomestico.Controls.Add(control);
        }

        private void ShowGastosTransporteView(object sender, EventArgs e)
        {
            IRegistroGastosTransporteView view = RegistroGastosTransporteView.GetInstance();
            IGastosTransporteRepository repository = new GastosTransporteRepository(stringConexao);
            new RegistroGastosTransportePresenter(usuarioLogado, view, repository);

            //Vincula a view ao TabPage
            var control = (Control)view;
            control.Dock = DockStyle.Fill;
            this.view.TbpTransporte.Controls.Clear();
            this.view.TbpTransporte.Controls.Add(control);
        }

        #endregion

    }
}
