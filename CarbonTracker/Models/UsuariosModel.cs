using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Models
{
    public class UsuariosModel
    {

        #region Propriedades

        [DisplayName("Usuario")]
        public long Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "Nome deve estar entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-Mail é obrigatório")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [DisplayName("Senha")]
        public string Senha { get; set; }

        [DisplayName("Tipo Usuários")]
        public TipoUsuario TipoUsuarios { get; set; }

        public DateTime DataCriacao { get; set; }

        #endregion

    }
}
