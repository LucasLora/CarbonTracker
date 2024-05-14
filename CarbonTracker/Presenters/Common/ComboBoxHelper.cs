using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonTracker.Presenters.Common
{
    public class ComboBoxHelper
    {
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public short Value { get; set; }

            public ComboBoxItem(string text, short value)
            {
                Text = text;
                Value = value;
            }
        }

        public static List<ComboBoxItem> GetEnumInComboBoxItemList<TEnum>()
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException("TEnum deve ser um enumerador!");
            }

            var values = Enum.GetValues(typeof(TEnum));
            var list = new List<ComboBoxItem>();

            foreach (TEnum value in values)
            {
                string description = GetEnumDescription(value);
                list.Add(new ComboBoxItem(description, Convert.ToInt16(value)));
            }

            return list;
        }

        private static string GetEnumDescription<TEnum>(TEnum value)
        {
            var fieldInfo = typeof(TEnum).GetField(value.ToString());
            var descriptionAttribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                                .OfType<DescriptionAttribute>()
                                                .FirstOrDefault();
            return descriptionAttribute != null ? descriptionAttribute.Description : value.ToString();
        }
    }
}

