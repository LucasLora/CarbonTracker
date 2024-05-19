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
            VincularEventos(); 
        }

        #endregion

        #region Métodos

        private void VincularEventos()
        {
            this.mainView.ShowUsuariosView += ShowUsuariosView;
            this.mainView.ShowGrupoUsuariosView += ShowGrupoUsuariosView;
            this.mainView.ShowEletrodomesticoView += ShowEletrodomesticoView;
            this.mainView.ShowTransporteView += ShowTransporteView;
            this.mainView.ShowRegistroGastosView += ShowRegistroGastosView;
            this.mainView.ShowComparacoesView += ShowComparacoesView;
    }

        #endregion

        #region Eventos

        private void ShowUsuariosView(object sender, EventArgs e)
        {
            IUsuariosView view = UsuariosView.GetInstance((Form)mainView);
            IUsuariosRepository repository = new UsuariosRepository(stringConexao);
            new UsuariosPresenter(view, repository);
        }      
        
        private void ShowGrupoUsuariosView(object sender, EventArgs e)
        {
            IGrupoUsuariosView view = GrupoUsuariosView.GetInstance((Form)mainView);
            IGrupoUsuariosRepository repository = new GrupoUsuariosRepository(stringConexao);
            new GrupoUsuariosPresenter(view, repository);
        }

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

        private void ShowRegistroGastosView(object sender, EventArgs e)
        {
        }

        private void ShowComparacoesView(object sender, EventArgs e)
        {
        }

        #endregion

    }
}
