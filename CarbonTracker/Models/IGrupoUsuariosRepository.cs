using System.Collections.Generic;

namespace CarbonTracker.Models
{
    public interface IGrupoUsuariosRepository
    {

        #region Métodos

        void Adicionar(GrupoUsuariosModel grupoUsuariosModel);
        void Alterar(GrupoUsuariosModel grupoUsuariosModel);
        void Excluir(long idGrupoUsuarios);
        IEnumerable<GrupoUsuariosModel> RetornarTodos();
        IEnumerable<GrupoUsuariosModel> RetornarPorId(string valor);

        #endregion

    }
}
