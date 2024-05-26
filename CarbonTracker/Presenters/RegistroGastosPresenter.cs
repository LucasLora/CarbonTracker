using CarbonTracker.Models;
using CarbonTracker.Views;
using System;

namespace CarbonTracker.Presenters
{
    public class RegistroGastosPresenter
    {

        #region Campos

        private readonly UsuariosModel usuarioLogado;
        private IRegistroGastosView view;
        private readonly string stringConexao;

        #endregion

        #region Construtor

        public RegistroGastosPresenter(UsuariosModel usuarioLogado, IRegistroGastosView mainView, string stringConexao)
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
            //IGrupoUsuariosView view = GrupoUsuariosView.GetInstance((Form)mainView);
            //IGrupoUsuariosRepository repository = new GrupoUsuariosRepository(stringConexao);
            //new GrupoUsuariosPresenter(view, repository);
        }

        private void ShowGastosTransporteView(object sender, EventArgs e)
        {
            //IGrupoUsuariosView view = GrupoUsuariosView.GetInstance((Form)mainView);
            //IGrupoUsuariosRepository repository = new GrupoUsuariosRepository(stringConexao);
            //new GrupoUsuariosPresenter(view, repository);
        }

        #endregion

    }
}
