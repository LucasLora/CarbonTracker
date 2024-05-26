using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public interface ICadastroGastosView
    {

        #region Propriedades

        TabPage TbpEletrodomestico { get; }
        TabPage TbpTransporte { get; }

        #endregion

        #region Eventos

        event EventHandler ShowPreCadastroEletrodomesticoView;
        event EventHandler ShowPreCadastroTransporteView;

        #endregion

        #region Métodos

        void Show();

        #endregion

    }
}
