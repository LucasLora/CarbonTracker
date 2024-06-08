namespace CarbonTracker.Models.Models
{
    public class GastosEletrodomesticoModel : GastosBaseModel
    {

        #region Propriedades

        public long IdEletrodomestico { get; set; }

        public double TempoUso { get; set; }

        public string NomeNRT { get; set; }

        public double LitroPorHoraAguaNRT { get; set; }

        public double KWPorHoraEletricidadeNRT { get; set; }

        #endregion

    }
}
