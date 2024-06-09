using System;
using System.Windows.Forms;

namespace CarbonTracker.Views.Interfaces
{
    public interface IRegistroGastosTransporteView
    {

        #region Propriedades

        DateTime Dia { get; set; }
        string SearchValue { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler RegistrarDiaEvent;
        event EventHandler TrocarDiaEvent;
        event EventHandler SearchEvent;
        event EventHandler SalvarEvent;
        event EventHandler RestaurarEvent;

        #endregion

        #region Métodos

        void BloquearDiaEDesbloquearRegistro(bool bloquear);
        void SetGastosTransporteListBindingSource(BindingSource gastosTransporteList);
        void Show();

        #endregion

    }
}
