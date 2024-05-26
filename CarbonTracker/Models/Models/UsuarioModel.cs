using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Models
{
    public class UsuarioModel : ICloneable
    {

        #region Propriedades

        [DisplayName("Usuário")]
        public long Id { get; set; }    

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nome deve estar entre 3 e 255 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-Mail é obrigatório")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }

        public TipoUsuario TipoUsuario { get; set; }    
        
        [DisplayName("Tipo Usuário")]
        public string TipoUsuarioDescription { get { return GetEnumDescription(TipoUsuario); } }

        [DisplayName("Data Criação")]
        public DateTime DataCriacao { get; set; }

        #endregion

        #region Métodos

        public object Clone()
        {
            return new UsuarioModel
            {
                Id = this.Id,
                Nome = this.Nome,
                Email = this.Email,
                Senha = this.Senha,
                TipoUsuario = this.TipoUsuario,
                DataCriacao = this.DataCriacao
            };
        }

        #endregion

    }
}
