namespace CarbonTracker.Models.Models
{
    public class GastosTransporteModel : GastosBaseModel
    {

        #region Propriedades

        public long IdTransporte { get; set; }

        public double KmRodados { get; set; }

        public int QtdePassageiros { get; set; }

        #endregion

    }
}
