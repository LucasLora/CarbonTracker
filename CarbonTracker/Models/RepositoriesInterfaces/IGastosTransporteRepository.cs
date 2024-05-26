using CarbonTracker.Models.Models;
using System;
using System.Collections.Generic;

namespace CarbonTracker.Models.RepositoriesInterfaces
{
    public interface IGastosTransporteRepository
    {

        #region Métodos

        void Adicionar(GastosTransporte gastosTransporte);
        void ExcluirPorUsuarioEDia(long idUsuario, DateTime dia);
        IEnumerable<GastosTransporte> RetornarPorUsuarioEDia(long idUsuario, DateTime dia);

        #endregion

    }
}
