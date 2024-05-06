using System.Collections.Generic;

namespace CarbonTracker.Models
{
    public interface IUsuariosRepository
    {

        #region Métodos

        void Adicionar(UsuariosModel usuariosModel);
        void Alterar(UsuariosModel usuariosModel);
        void Excluir(long idUsuario);
        IEnumerable<UsuariosModel> RetornarTodos();
        IEnumerable<UsuariosModel> RetornarPorId(string valor);

        #endregion

    }
}
