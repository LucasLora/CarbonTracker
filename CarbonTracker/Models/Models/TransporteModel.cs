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

        public TipoVeiculo TipoVeiculo { get; set; }

        [DisplayName("Tipo Veículo")]
        public string TipoVeiculoDescription { get { return GetEnumDescription(TipoVeiculo); } }

        public TipoCombustivel TipoCombustivel { get; set; }

        [DisplayName("Tipo Combustível")]
        public string TipoCombustivelDescription { get { return GetEnumDescription(TipoCombustivel); } }

        [DisplayName("Km/L Combustível")]
        public double KmPorLitroCombustivel { get; set; }

        #endregion

    }
}
