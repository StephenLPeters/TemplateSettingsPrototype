using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace TemplateSettingsPrototype
{
    public abstract class TemplateSettingsPrototypeBase<T> :DependencyObject where T : Enum 
    {
        public object[] MyProperties
        {
            get { return (object[])GetValue(MyPropertiesProperty); }
            set { SetValue(MyPropertiesProperty, value); }
        }

        public static readonly DependencyProperty MyPropertiesProperty =
           DependencyProperty.Register("MyProperties", typeof(object[]), typeof(AreaExamplesTemplateSettings), new PropertyMetadata(new object[] { 10.0, 10.0 }));

        public abstract Type PropertyType(T name);
    }
}
