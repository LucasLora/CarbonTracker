using CarbonTracker.Models.Models;
using System.Collections.Generic;

namespace CarbonTracker.Models.RepositoriesInterfaces
{
    public interface IUsuarioXGrupoUsuariosRepository
    {

        #region Métodos

        void Adicionar(UsuarioXGrupoUsuariosModel usuarioXGrupoUsuarios);
        void ExcluirPorUsuario(long idUsuario);
        IEnumerable<UsuarioXGrupoUsuariosModel> RetornarTodosGruposComInformacoesDePresencaDoUsuario(long idUsuario);

        #endregion

    }
}
