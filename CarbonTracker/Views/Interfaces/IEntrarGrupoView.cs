using CarbonTracker.Models;
using CarbonTracker.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonTracker.Views.Interfaces
{
    public interface IEntrarGrupoView
    {

        #region Propriedades

        string SearchValue { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler SearchEvent;
        event EventHandler SalvarEvent;
        event EventHandler RestaurarEvent;

        #endregion

        #region Métodos

        void SetGrupoUsuariosListBindingSource(BindingSource grupoUsuariosList);
        void Show();

        #endregion

    }
}
