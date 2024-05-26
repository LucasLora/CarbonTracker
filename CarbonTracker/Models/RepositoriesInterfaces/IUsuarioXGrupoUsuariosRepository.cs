using CarbonTracker.Models.Models;
using System.Collections.Generic;

namespace CarbonTracker.Models.RepositoriesInterfaces
{
    public interface IUsuarioXGrupoUsuariosRepository
    {

        #region Métodos

        void Adicionar(UsuarioXGrupoUsuarios usuarioXGrupoUsuarios);
        void ExcluirPorUsuario(long idUsuario);
        IEnumerable<UsuarioXGrupoUsuarios> RetornarPorUsuario(long idUsuario);

        #endregion

    }
}
