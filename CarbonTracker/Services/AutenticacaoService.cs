using CarbonTracker.Models;
using System.Configuration;
using System.Linq;

namespace CarbonTracker.Services
{
    public class AutenticacaoService
    {

        #region Campos

        private readonly IUsuariosRepository usuariosRepository;
        private UsuarioModel usuarioAutenticado = null;

        #endregion

        #region Propriedades

        public UsuarioModel UsuarioAutenticado { get { return usuarioAutenticado; } }

        #endregion

        #region Construtor

        public AutenticacaoService(IUsuariosRepository usuariosRepository)
        {
            this.usuariosRepository = usuariosRepository;
        }

        #endregion

        #region Métodos

        public bool Autenticar(string username, string password)
        {
            if (!ExisteUsuarioAdministrador()) //Deve existir um usuário administrador no sistema
            {
                CriaUsuarioAdministrador(); //Se não existir, cria um usuário administrador
            }

            var user = usuariosRepository.RetornarTodos().FirstOrDefault(x => x.Email == username);
            if (user != null && user.Senha == password)
            {
                usuarioAutenticado = user;
                return true;
            }
            return false;
        }

        public bool ExisteUsuarioAdministrador()
        {
            return usuariosRepository.RetornarTodos().ToList().Any(x => x.TipoUsuario == Models.Common.Enums.TipoUsuario.Administrador);
        }

        public void CriaUsuarioAdministrador()
        {
            usuariosRepository.Adicionar(new UsuarioModel
            {
                Nome = "Administrador",
                Email = "Administrador",
                Senha = "Admin123",
                TipoUsuario = Models.Common.Enums.TipoUsuario.Administrador,
                DataCriacao = System.DateTime.Now
            });
        }

        #endregion

    }
}
