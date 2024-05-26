using System.Collections.Generic;

namespace CarbonTracker.Models
{
    public interface IUsuariosRepository
    {

        #region Métodos

        void Adicionar(UsuarioModel usuariosModel);
        void Alterar(UsuarioModel usuariosModel);
        void Excluir(long idUsuario);
        IEnumerable<UsuarioModel> RetornarTodos();
        IEnumerable<UsuarioModel> RetornarPorId(string valor);

        #endregion

    }
}
