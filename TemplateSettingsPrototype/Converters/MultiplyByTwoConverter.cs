using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSettingsPrototype.Converters
{
    class MultiplyByTwoConverter : PrototypeConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, String language)
        {
            var properties = getValues(value, parameter);
            return ((double)properties[0]) * 2.0;
        }
    }
}
