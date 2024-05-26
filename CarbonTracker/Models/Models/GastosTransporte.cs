namespace CarbonTracker.Models.Models
{
    public class GastosTransporte : GastosBase
    {

        #region Propriedades

        public long IdTransporte { get; set; }
        public decimal KmRodados { get; set; }
        public int QtdePassageiros { get; set; }

        #endregion

    }
}
