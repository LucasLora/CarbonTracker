using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CarbonTracker.Models
{
    public class GrupoUsuariosModel
    {

        #region Propriedades

        [DisplayName("Grupo")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome deve estar entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [StringLength(1000, ErrorMessage = "Descrição deve ter no máximo 1000 caracteres")]
        public string Descricao { get; set; }

        #endregion

    }
}
