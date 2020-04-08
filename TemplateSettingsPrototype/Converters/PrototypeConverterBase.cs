using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace TemplateSettingsPrototype.Converters
{
    public abstract class PrototypeConverterBase<T> : IValueConverter where T : Enum
    {
        public TemplateSettingsPrototypeBase<T> templateSettings;
        public object[] getValues(object value, object parameter)
        {
            string[] parameters = ((string)parameter).Split(new char[] { '|' });
            object[] values = (object[])value;
            object[] returns = new object[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                int index;
                int.TryParse((string)parameter, out index);
                returns[i] = values[index];
            }
            return returns;
        }

        public Type[] getTypes(object parameter)
        {
            string[] parameters = ((string)parameter).Split(new char[] { '|' });
            Type[] returns = new Type[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                int index;
                int.TryParse((string)parameter, out index);
                returns[i] = templateSettings.PropertyType((T)(object)index);
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
