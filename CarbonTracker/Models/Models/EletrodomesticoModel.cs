using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarbonTracker.Models
{
    public class EletrodomesticoModel
    {

        #region Propriedades

        [DisplayName("Eletrodoméstico")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome deve estar entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [DisplayName("L/h Água")]
        public double LitroPorHoraAgua { get; set; }

        [DisplayName("kW/h Eletricidade")]
        public double KWPorHoraEletricidade { get; set; }

        #endregion

    }
}
