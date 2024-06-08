using CarbonTracker.Models.Models;
using System;
using System.Collections.Generic;

namespace CarbonTracker.Models.RepositoriesInterfaces
{
    public interface IGastosTransporteRepository
    {

        #region Métodos

        void Adicionar(GastosTransporteModel gastosTransporte);
        void Alterar(GastosTransporteModel gastosTransporte);
        void ExcluirPorUsuarioEDia(long idUsuario, DateTime dia);
        IEnumerable<GastosTransporteModel> RetornarPorUsuarioEDia(long idUsuario, DateTime dia);

        #endregion

    }
}
