using CarbonTracker.Models.Models;
using System;
using System.Collections.Generic;

namespace CarbonTracker.Models.RepositoriesInterfaces
{
    public interface IGastosEletrodomesticoRepository
    {

        #region Métodos

        void Adicionar(GastosEletrodomestico gastosEletrodomestico);
        void ExcluirPorUsuarioEDia(long idUsuario, DateTime dia);
        IEnumerable<GastosEletrodomestico> RetornarPorUsuarioEDia(long idUsuario, DateTime dia);

        #endregion

    }
}
