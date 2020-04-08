using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace TemplateSettingsPrototype.Converters
{
    public abstract class PrototypeConverterBase : IValueConverter
    {
        public object[] getValues(object value, object parameter)
        {
            string[] parameters = ((string)parameter).Split(new char[] { '|' });
            object[] values = (object[])value;
            object[] returns = new object[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                int index;
                int.TryParse((string)parameters[i], out index);
                returns[i] = values[index];
            }
            return returns;
        }
        public virtual object Convert(object value, Type targetType, object parameter, String language)
        {
            throw new NotImplementedException();
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
