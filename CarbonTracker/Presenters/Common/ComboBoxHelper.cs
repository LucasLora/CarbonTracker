using System;
using System.Collections.Generic;
using static CarbonTracker.Models.Common.Enums;

namespace CarbonTracker.Presenters.Common
{
    public class ComboBoxHelper
    {

        #region Classes Auxiliares

        public class ComboBoxItem
        {

            #region Propriedades

            public string Text { get; set; }
            public short Value { get; set; }

            #endregion

            #region Construtor

            public ComboBoxItem(string text, short value)
            {
                Text = text;
                Value = value;
            }

            #endregion

        }

        #endregion

        #region Métodos

        public static List<ComboBoxItem> GetComboBoxItemListFromEnum<TEnum>()
        {
            Type enumType = typeof(TEnum);

            if (!enumType.IsEnum)
                throw new ArgumentException("TEnum deve ser um enumerador!");

            var values = Enum.GetValues(enumType);
            var list = new List<ComboBoxItem>();

            foreach (TEnum value in values)
            {
                string description = GetEnumDescription(value);
                list.Add(new ComboBoxItem(description, Convert.ToInt16(value)));
            }

            return list;
        }

        #endregion

    }
}

