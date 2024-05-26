using CarbonTracker.Models;
using System.Linq;

namespace CarbonTracker.Services
{
    public class AutenticacaoService
    {

        #region Campos

        private readonly IUsuariosRepository _usuariosRepository;
        private UsuarioModel usuarioAutenticado = null;

        #endregion

        #region Propriedades

        public UsuarioModel UsuarioAutenticado { get { return usuarioAutenticado; } }

        #endregion

        #region Construtor

        public AutenticacaoService(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        #endregion

        #region Métodos

        public bool Autenticar(string username, string password)
        {
            var user = _usuariosRepository.RetornarTodos().FirstOrDefault(x => x.Email == username);
            if (user != null && user.Senha == password)
            {
                usuarioAutenticado = user;
                return true;
            }
            return false;
        }

        #endregion

    }
}
