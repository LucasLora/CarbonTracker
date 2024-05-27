using System.ComponentModel.DataAnnotations;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Models
{
    public class TransporteModel
    {

        #region Propriedades

        public long Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome deve estar entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }

        public string TipoVeiculoDescription { get { return GetEnumDescription(TipoVeiculo); } }

        public TipoCombustivel TipoCombustivel { get; set; }

        public string TipoCombustivelDescription { get { return GetEnumDescription(TipoCombustivel); } }

        public double KmPorLitroCombustivel { get; set; }

        #endregion

    }
}
