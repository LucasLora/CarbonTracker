using System;
using System.ComponentModel;

namespace CarbonTracker.Models.Common
{
    public class Enums
    {

        #region Enumeradores

        public enum TipoCombustivel : short
        {
            [Description("Não Aplica")]
            NaoAplica = 0,

            [Description("Elétrico")]
            Eletrico = 1,

            [Description("Gasolina")]
            Gasolina = 2,

            [Description("Diesel")]
            Diesel = 3,

            [Description("Etanol")]
            Etanol = 4,

            [Description("Flex")]
            Flex = 5,

            [Description("GNV")]
            GNV = 6,

        }

        public enum TipoVeiculo : short
        {
            [Description("Moto")]
            Moto = 0,

            [Description("Carro")]
            Carro = 1,

            [Description("Van")]
            Van = 2,

            [Description("Ônibus")]
            Onibus = 3,

            [Description("Trem")]
            Trem = 4,

            [Description("Caminhão")]
            Caminhao = 5,

            [Description("Bicicleta")]
            Bicicleta = 6,

            [Description("Patinete")]
            Patinete = 7,

            [Description("Avião")]
            Aviao = 8,

            [Description("Helicóptero")]
            Helicoptero = 9,

            [Description("Navio")]
            Navio = 10,

            [Description("Barco")]
            Barco = 11,

            [Description("Lancha")]
            Lancha = 12
        }

        public enum TipoUsuario : short
        {
            [Description("Administrador")]
            Administrador = 0,

            [Description("Supervisor")]
            Supervisor = 1,

            [Description("Usuário")]
            Usuario = 2
        }

        #endregion

        #region Métodos

        public static string GetEnumDescription<TEnum>(TEnum value)
        {
            Type enumType = typeof(TEnum);

            if (!enumType.IsEnum)
                throw new ArgumentException("TEnum deve ser um enumerador!");
            
            string name = Enum.GetName(enumType, value);

            if (name == null)
                return null;         

            var fieldInfo = enumType.GetField(name);
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
            return attribute != null ? attribute.Description : name;
        }

        #endregion

    }
}
