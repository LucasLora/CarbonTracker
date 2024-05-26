using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public interface IPreCadastroGastosView
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
