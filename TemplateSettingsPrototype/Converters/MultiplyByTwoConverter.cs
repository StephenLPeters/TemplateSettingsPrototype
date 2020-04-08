using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSettingsPrototype.Converters
{
    class MultiplyByTwoConverter<T> : PrototypeConverterBase<T> where T:Enum
    {
        public override object Convert(object value, Type targetType, object parameter, String language)
        {
            var properties = getValues(value, parameter);
            var types = getTypes(parameter);

            Type type = types[0];
            dynamic returnvalue =  System.Convert.ChangeType(properties[0], type);
            return returnvalue * 2;
        }
    }
}
