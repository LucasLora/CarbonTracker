using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarbonTracker.Models.Common
{
    public class Enums
    {

        public static string GetEnumDescription<TEnum>(TEnum value) where TEnum : Enum
        {
            Type enumType = typeof(TEnum);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException("TEnum deve ser um enumerador");
            }

            string name = Enum.GetName(enumType, value);

            if (name == null)
            {
                return null;
            }

            var fieldInfo = enumType.GetField(name);
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
            return attribute != null ? attribute.Description : name;
        }

        public enum TipoCombustivel : short
        {
            [Description("Não Aplica")]
            NaoAplica = 0,

            [Description("Etanol")]
            Etanol = 1,

            [Description("Diesel")]
            Diesel = 2,

            [Description("Gasolina")]
            Gasolina = 3,

            [Description("GNV")]
            GNV = 4,

            [Description("Flex")]
            Flex = 5,

            [Description("Álcool")]
            Alcool = 5,

            [Description("Elétrico")]
            Eletrico = 6,
        }

        public enum TipoVeiculo
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
        public enum TipoUsuario
        {
            [Description("Administrador")]
            Administrador = 0,

            [Description("Supervisor")]
            Supervisor = 1,

            [Description("Usuário")]
            Usuario = 2
        }

    }
}
