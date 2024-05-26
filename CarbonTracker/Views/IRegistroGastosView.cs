using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public interface IRegistroGastosView
    {

        #region Propriedades

        TabPage TbpEletrodomestico { get; }
        TabPage TbpTransporte { get; }

        #endregion

        #region Eventos

        event EventHandler ShowGastosEletrodomesticoView;
        event EventHandler ShowGastosTransporteView;

        #endregion

        #region Métodos

        void Show();

        #endregion

    }
}
