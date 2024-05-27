using System.ComponentModel.DataAnnotations;

namespace CarbonTracker.Models
{
    public class GrupoUsuariosModel
    {

        #region Propriedades

        public long Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome deve estar entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [StringLength(5000, ErrorMessage = "Descrição deve ter no máximo 5000 caracteres!")]
        public string Descricao { get; set; }

        #endregion

    }
}
