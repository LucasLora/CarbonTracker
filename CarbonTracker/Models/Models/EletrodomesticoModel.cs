using System.ComponentModel.DataAnnotations;

namespace CarbonTracker.Models
{
    public class EletrodomesticoModel
    {

        #region Propriedades

        public long Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome deve estar entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        public double LitroPorHoraAgua { get; set; }

        public double KWPorHoraEletricidade { get; set; }

        #endregion

    }
}
