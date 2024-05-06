using System.Collections.Generic;

namespace CarbonTracker.Models
{
    public interface ITransporteRepository
    {

        #region Métodos

        void Adicionar(TransporteModel transporteModel);
        void Alterar(TransporteModel transporteModel);
        void Excluir(long idTransporte);
        IEnumerable<TransporteModel> RetornarTodos();
        IEnumerable<TransporteModel> RetornarPorId(string valor);

        #endregion

    }
}
