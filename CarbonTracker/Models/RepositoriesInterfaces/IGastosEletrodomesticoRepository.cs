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
        IEnumerable<GastosEletrodomesticoModel> RetornarPorUsuarioEDia(long idUsuario, DateTime dia);

        #endregion

    }
}
