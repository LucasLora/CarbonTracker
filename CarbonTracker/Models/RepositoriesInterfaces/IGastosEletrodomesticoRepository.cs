using CarbonTracker.Models.Models;
using System;
using System.Collections.Generic;

namespace CarbonTracker.Models.RepositoriesInterfaces
{
    public interface IGastosEletrodomesticoRepository
    {

        #region Métodos

        void Adicionar(GastosEletrodomesticoModel gastosEletrodomestico);
        void Alterar(GastosEletrodomesticoModel gastosEletrodomestico);
        void ExcluirPorUsuarioEDia(long idUsuario, DateTime dia);
        IEnumerable<GastosEletrodomesticoModel> RetornarPorUsuarioEDiaParaCadastro(long idUsuario, DateTime dia);
        IEnumerable<GastosEletrodomesticoModel> RetornaPorUsuarioEIntervaloDatasParaCalculo(long idUsuario, DateTime dataInicio, DateTime dataFim);

        #endregion

    }
}
