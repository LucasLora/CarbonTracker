using System;
using System.Windows.Forms;

namespace CarbonTracker.Views
{
    public interface IEletrodomesticoView
    {

        #region Propriedades 

        string EletrodomesticoId { get; set; }
        string EletrodomesticoNome { get; set; }
        string EletrodomesticoLitroPorHoraAgua { get; set; }
        string EletrodomesticoKWPorHoraEletricidade { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        #endregion

        #region Eventos

        event EventHandler SearchEvent;
        event EventHandler AdicionarEvent;
        event EventHandler AlterarEvent;
        event EventHandler ExcluirEvent;
        event EventHandler SalvarEvent;
        event EventHandler CancelarEvent;

        #endregion

        #region Métodos

        void SetEletrodomesticoListBindingSource(BindingSource eletrodomesticoList);
        void Show();

        #endregion

    }
}
