using System.Collections.Generic;

namespace CarbonTracker.Models
{
    public interface IEletrodomesticoRepository
    {

        #region Métodos

        void Adicionar(EletrodomesticoModel eletrodomesticoModel);
        void Alterar(EletrodomesticoModel eletrodomesticoModel);
        void Excluir(long idEletrodomestico);
        IEnumerable<EletrodomesticoModel> RetornarTodos();
        IEnumerable<EletrodomesticoModel> RetornarPorId(string valor);

        #endregion

    }
}
