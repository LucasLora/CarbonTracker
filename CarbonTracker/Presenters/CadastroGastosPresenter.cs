using CarbonTracker._Repositories;
using CarbonTracker.Models;
using CarbonTracker.Views;
using System;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class CadastroGastosPresenter
    {

        #region Campos

        private ICadastroGastosView view;
        private readonly string stringConexao;

        #endregion

        #region Construtor

        public CadastroGastosPresenter(ICadastroGastosView mainView, string stringConexao)
        {
            this.view = mainView;
            this.stringConexao = stringConexao;

            VincularEventos();

            this.view.Show();
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.view.ShowPreCadastroEletrodomesticoView += ShowPreCadastroEletrodomesticoView;
            this.view.ShowPreCadastroTransporteView += ShowPreCadastroTransporteView;
        }

        #endregion

        #region Eventos

        private void ShowPreCadastroEletrodomesticoView(object sender, EventArgs e)
        {
            ICadastroEletrodomesticoView eletrodomesticoView = CadastroEletrodomesticoView.GetInstance();
            IEletrodomesticoRepository repository = new EletrodomesticoRepository(stringConexao);
            new CadastroEletrodomesticoPresenter(eletrodomesticoView, repository);

            //Vincula a view ao TabPage
            var eletrodomesticoControl = (Control)eletrodomesticoView;
            eletrodomesticoControl.Dock = DockStyle.Fill;
            view.TbpEletrodomestico.Controls.Clear();
            view.TbpEletrodomestico.Controls.Add(eletrodomesticoControl);
        }

        private void ShowPreCadastroTransporteView(object sender, EventArgs e)
        {
            ICadastroTransporteView transporteView = CadastroTransporteView.GetInstance();
            ITransporteRepository repository = new TransporteRepository(stringConexao);
            new CadastroTransportePresenter(transporteView, repository);

            //Vincula a view ao TabPage
            var transporteControl = (Control)transporteView;
            transporteControl.Dock = DockStyle.Fill;
            view.TbpTransporte.Controls.Clear();
            view.TbpTransporte.Controls.Add(transporteControl);
        }

        #endregion

    }
}
