using System;
using CarbonTracker.Views;
using CarbonTracker.Models;
using CarbonTracker._Repositories;
using System.Windows.Forms;

namespace CarbonTracker.Presenters
{
    public class MainPresenter
    {

        #region Campos

        private IMainView mainView;
        private readonly string stringConexao;

        #endregion

        #region Construtor

        public MainPresenter(IMainView mainView, string stringConexao)
        {
            this.mainView = mainView;
            this.stringConexao = stringConexao;
            this.mainView.ShowEletrodomesticoView += ShowEletrodomesticoView;
            this.mainView.ShowTransporteView += ShowTransporteView;
            this.mainView.ShowUsuariosView += ShowUsuariosView;
        }

        #endregion

        #region Métodos

        private void ShowEletrodomesticoView(object sender, EventArgs e)
        {
            IEletrodomesticoView view = EletrodomesticoView.GetInstance((Form)mainView);
            IEletrodomesticoRepository repository = new EletrodomesticoRepository(stringConexao);
            new EletrodomesticoPresenter(view, repository);
        }

        private void ShowTransporteView(object sender, EventArgs e)
        {
            ITransporteView view = TransporteView.GetInstance((Form)mainView);
            ITransporteRepository repository = new TransporteRepository(stringConexao);
            new TransportePresenter(view, repository);
        }

        private void ShowUsuariosView(object sender, EventArgs e)
        {
            IUsuariosView view = UsuariosView.GetInstance((Form)mainView);
            IUsuariosRepository repository = new UsuariosRepository(stringConexao);
            new UsuariosPresenter(view, repository);
        }

        #endregion

    }
}
