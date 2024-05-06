using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Views
{
    public interface ITransporteView
    {

        #region Propriedades

        string TransporteId { get; set; }
        string TransporteNome { get; set; }
        TipoVeiculo TransporteTipoVeiculo { get; set; }
        TipoCombustivel TransporteTipoCombustivel { get; set; }
        string TransporteKmPorLitroCombustivel { get; set; }
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

        void SetTransporteListBindingSource(BindingSource transporteList);
        void SetComboBoxCombustivel(List<TipoCombustivel> combustivelList);
        void SetComboBoxVeiculo(List<TipoVeiculo> veiculoList);
        void Show();

        #endregion

    }
}
