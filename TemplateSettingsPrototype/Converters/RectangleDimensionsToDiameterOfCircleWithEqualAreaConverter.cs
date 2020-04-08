using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSettingsPrototype.Converters
{
    class RectangleDimensionsToDiameterOfCircleWithEqualAreaConverter<T> : PrototypeConverterBase<T> where T : Enum
    {
        public override object Convert(object value, Type targetType, object parameter, String language)
        {
            var properties = getValues(value, parameter);
            var area = ((double)properties[0]) * ((double)properties[1]);
            return Math.Sqrt(area / Math.PI) * 2;
        }
    }
}
