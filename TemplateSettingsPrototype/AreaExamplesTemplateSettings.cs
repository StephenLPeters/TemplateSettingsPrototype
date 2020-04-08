using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateSettingsPrototype
{
    public enum AreaExamplesTemplateSettingsPropertyNames
    {
        ExampleWidth,
        ExampleHeight
    }

    public class AreaExamplesTemplateSettings : TemplateSettingsPrototypeBase<AreaExamplesTemplateSettingsPropertyNames>
    {
        public override Type PropertyType(AreaExamplesTemplateSettingsPropertyNames name)
        {
            switch (name)
            {
                case AreaExamplesTemplateSettingsPropertyNames.ExampleHeight:
                    return typeof(double);
                case AreaExamplesTemplateSettingsPropertyNames.ExampleWidth:
                default:
                    return typeof(double);
            }
        }
    }
}
