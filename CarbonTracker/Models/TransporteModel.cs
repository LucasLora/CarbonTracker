using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Models
{
    public class TransporteModel
    {

        #region Propriedades

        [DisplayName("Transporte")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome deve estar entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [DisplayName("Tipo Veículo")]
        public TipoVeiculo TipoVeiculo { get; set; }

        [DisplayName("Tipo Combustível")]
        public TipoCombustivel TipoCombustivel { get; set; }

        [DisplayName("Km/L Combustível")]
        public double KmPorLitroCombustivel { get; set; }

        #endregion

    }
}
