using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarbonTracker.Models.Common.Enums;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public interface IAlterarInformacoesUsuarioLogado
    {
        #region Propriedades

        string UsuariosNome { get; set; }
        string UsuariosEmail { get; set; }
        string UsuariosSenha { get; set; }
        string UsuariosRepetirSenha { get; }

        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler SalvarEvent;

        #endregion

        #region Métodos

        void Show();

        #endregion

    }
}
