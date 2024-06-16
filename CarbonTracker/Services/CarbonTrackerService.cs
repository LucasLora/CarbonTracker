using CarbonTracker.Models.Models;
using System;
using System.Collections.Generic;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Services
{
    public class CarbonTrackerService
    {

        #region Geral

        //Método para calcular a pegada de carbono total
        public double CalcularPegadaCarbonoTotal(List<GastosTransporteModel> registrosTransporte, List<GastosEletrodomesticoModel> registrosEletrodomesticos)
        {
            double pegadaTransporte = CalcularPegadaCarbonoTransporte(registrosTransporte);
            double pegadaEletrodomesticos = CalcularPegadaCarbonoEletrodomesticos(registrosEletrodomesticos);
            return pegadaTransporte + pegadaEletrodomesticos;
        }

        #endregion

        #region Transporte

        #region Constantes

        //Valores aproximados de emissões de CO2 por litro de combustível em kg
        private const double EMISSAO_CO2_GASOLINA = 2.31;
        private const double EMISSAO_CO2_DIESEL = 2.68;
        private const double EMISSAO_CO2_ETANOL = 1.91;
        private const double EMISSAO_CO2_GNV = 1.78;

        //Redução de pegada por uso de transporte não poluente
        private const double REDUCAO_CO2_POR_KM_NAO_POLUENTE = 0.35;

        #endregion

        //Método para calcular a pegada de carbono do transporte
        public double CalcularPegadaCarbonoTransporte(List<GastosTransporteModel> registrosTransporte)
        {
            double pegadaTotal = 0.0;

            foreach (var registro in registrosTransporte)
            {
                //Verificação para tipos de transporte não poluentes ou não aplicáveis, que ajudam a reduzir a pegada de carbono
                if (registro.TipoCombustivelNRT == TipoCombustivel.NaoAplica)
                {
                    pegadaTotal -= CalcularReducaoPegadaNaoPoluente(registro.KmRodados);
                    continue;
                }

                //Se for veículo elétrico, a pegada é zero, por ser um meio de transporte mais sustentável
                if (registro.TipoCombustivelNRT == TipoCombustivel.Eletrico)
                {
                    continue;
                }

                //Validação da eficiência de combustível
                if (registro.KmPorLitroCombustivelNRT <= 0)
                {
                    throw new ArgumentException("O transporte deve ter Km/L cadastrado");
                }

                //Adiciona pegada de carbono de veículos a combustível
                pegadaTotal += CalcularPegadaTransporteIndividual(registro);
            }

            return pegadaTotal;
        }

        //Método para calcular a redução da pegada de carbono para transportes não poluentes
        private double CalcularReducaoPegadaNaoPoluente(double kmRodados)
        {
            return kmRodados * REDUCAO_CO2_POR_KM_NAO_POLUENTE;
        }

        //Método para calcular a pegada de carbono individual do transporte
        private double CalcularPegadaTransporteIndividual(GastosTransporteModel registro)
        {
            double emissaoCO2PorLitroCombustivel = ObterEmissaoCO2PorCombustivel(registro.TipoCombustivelNRT);
            double emissaoTotal = (registro.KmRodados / registro.KmPorLitroCombustivelNRT) * emissaoCO2PorLitroCombustivel;

            //Número de passageiros. Se não houver passageiros, assume-se 1 para evitar divisão por zero.
            int numeroPassageiros = registro.QtdePassageiros > 0 ? registro.QtdePassageiros : 1;

            //Divide a emissão total pelo número de passageiros, para diminuir a pegada para transporte compartilhado
            return emissaoTotal / numeroPassageiros;
        }

        //Método para obter a emissão de CO2 por tipo de combustível
        private double ObterEmissaoCO2PorCombustivel(TipoCombustivel tipoCombustivel)
        {
            switch (tipoCombustivel)
            {
                case TipoCombustivel.Gasolina: return EMISSAO_CO2_GASOLINA;
                case TipoCombustivel.Diesel: return EMISSAO_CO2_DIESEL;
                case TipoCombustivel.Etanol: return EMISSAO_CO2_ETANOL;
                case TipoCombustivel.Flex: return (EMISSAO_CO2_GASOLINA + EMISSAO_CO2_ETANOL) / 2; //Aproximação para veículos Flex
                case TipoCombustivel.GNV: return EMISSAO_CO2_GNV;
                default: throw new ArgumentOutOfRangeException(nameof(tipoCombustivel), $"Tipo de combustível não suportado: {tipoCombustivel}");
            }
        }

        #endregion

        #region Eletrodomésticos

        #region Constantes

        //Valor aproximado de emissão de CO2 por kWh em kg
        private const double EMISSAO_CO2_POR_KWH = 0.233;

        //Valor fictício médio de emissão de CO2 por litro de água em kg
        private const double EMISSAO_CO2_POR_LITRO_AGUA = 0.001; //Valor fictício médio, porque um valor real e exato depende da fonte da água

        #endregion

        //Método para calcular a pegada de carbono dos eletrodomésticos
        public double CalcularPegadaCarbonoEletrodomesticos(List<GastosEletrodomesticoModel> registrosEletrodomesticos)
        {
            double pegadaTotal = 0.0;
            foreach (var registro in registrosEletrodomesticos)
            {
                pegadaTotal += CalcularPegadaEletrodomesticoIndividual(registro);
            }
            return pegadaTotal;
        }

        //Método para calcular a pegada de carbono individual de um eletrodoméstico
        private double CalcularPegadaEletrodomesticoIndividual(GastosEletrodomesticoModel registro)
        {
            double pegadaCO2KWH = CalcularPegadaEnergiaEletrica(registro.KWPorHoraEletricidadeNRT, registro.TempoUso);
            double pegadaCO2Agua = CalcularPegadaConsumoAgua(registro.LitroPorHoraAguaNRT, registro.TempoUso);
            return pegadaCO2KWH + pegadaCO2Agua;
        }

        //Método para calcular a pegada de carbono pelo consumo de energia elétrica
        private double CalcularPegadaEnergiaEletrica(double consumoKWH, double tempoUsoMinutos)
        {
            double tempoUsoHoras = tempoUsoMinutos / 60.0;
            return consumoKWH * EMISSAO_CO2_POR_KWH * tempoUsoHoras;
        }

        //Método para calcular a pegada de carbono pelo consumo de água
        private double CalcularPegadaConsumoAgua(double consumoLitrosPorHora, double tempoUsoMinutos)
        {
            double tempoUsoHoras = tempoUsoMinutos / 60.0;
            return consumoLitrosPorHora * EMISSAO_CO2_POR_LITRO_AGUA * tempoUsoHoras;
        }

        #endregion

    }
}
