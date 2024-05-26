using CarbonTracker._Repositories;
using CarbonTracker.Models;
using CarbonTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class PreCadastroGastosPresenter
    {
        #region Campos

        private IPreCadastroGastosView view;
        private readonly string stringConexao;

        #endregion

        #region Construtor

        public PreCadastroGastosPresenter(IPreCadastroGastosView mainView, string stringConexao)
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
            IEletrodomesticoView eletrodomesticoView = EletrodomesticoView.GetInstance();
            IEletrodomesticoRepository repository = new EletrodomesticoRepository(stringConexao);
            new EletrodomesticoPresenter(eletrodomesticoView, repository);

            //Vincula a view ao TabPage
            var eletrodomesticoControl = (Control)eletrodomesticoView;
            eletrodomesticoControl.Dock = DockStyle.Fill;
            view.TbpEletrodomestico.Controls.Clear();
            view.TbpEletrodomestico.Controls.Add(eletrodomesticoControl);
        }

        private void ShowPreCadastroTransporteView(object sender, EventArgs e)
        {
            ITransporteView transporteView = TransporteView.GetInstance();
            ITransporteRepository repository = new TransporteRepository(stringConexao);
            new TransportePresenter(transporteView, repository);

            //Vincula a view ao TabPage
            var transporteControl = (Control)transporteView;
            transporteControl.Dock = DockStyle.Fill;
            view.TbpTransporte.Controls.Clear();
            view.TbpTransporte.Controls.Add(transporteControl);
        }

        #endregion

    }
}
