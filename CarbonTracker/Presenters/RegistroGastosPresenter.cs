using CarbonTracker.Models;
using CarbonTracker.Views;
using System;

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

        }

        private void ShowGastosTransporteView(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
