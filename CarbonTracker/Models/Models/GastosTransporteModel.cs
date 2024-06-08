using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Models.Models
{
    public class GastosTransporteModel : GastosBaseModel
    {

        #region Propriedades

        public long IdTransporte { get; set; }

        public double KmRodados { get; set; }

        public int QtdePassageiros { get; set; }

        public string NomeNRT { get; set; }

        public TipoVeiculo TipoVeiculoNRT { get; set; }

        public string TipoVeiculoDescriptionNRT { get { return GetEnumDescription(TipoVeiculoNRT); } }

        public TipoCombustivel TipoCombustivelNRT { get; set; }

        public string TipoCombustivelDescriptionNRT { get { return GetEnumDescription(TipoCombustivelNRT); } }

        public double KmPorLitroCombustivelNRT { get; set; }

        #endregion

    }
}
