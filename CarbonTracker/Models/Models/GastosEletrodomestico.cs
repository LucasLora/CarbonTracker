namespace CarbonTracker.Models.Models
{
    public class GastosEletrodomestico : GastosBase
    {

        #region Propriedades

        public long IdEletrodomestico { get; set; }
        public decimal TempoUso { get; set; }

        #endregion
    }
}
