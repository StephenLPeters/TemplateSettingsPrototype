using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TemplateSettingsPrototype.Converters;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace TemplateSettingsPrototype
{
    public sealed class AreaExamples : Control
    {
        public AreaExamples()
        {
            this.DefaultStyleKey = typeof(AreaExamples);
        }

        public AreaExamplesTemplateSettings AreaExamplesTemplateSettings { get; } = new AreaExamplesTemplateSettings();

        public double ExampleWidth
        {
            get { return (double)GetValue(ExampleWidthProperty); }
            set { SetValue(ExampleWidthProperty, value); }
        }

        public static readonly DependencyProperty ExampleWidthProperty = DependencyProperty.Register("ExampleWidth", typeof(double), typeof(AreaExamples), new PropertyMetadata(100.0, new PropertyChangedCallback(OnExampleWidthChanged)));

        public static void OnExampleWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((AreaExamples)d).UpdateTemplateSettings();
        }

        public double ExampleHeight
        {
            get { return (double)GetValue(ExampleHeightProperty); }
            set { SetValue(ExampleHeightProperty, value); }
        }

        public static readonly DependencyProperty ExampleHeightProperty = DependencyProperty.Register("ExampleHeight", typeof(double), typeof(AreaExamples), new PropertyMetadata(100.0, new PropertyChangedCallback(OnExampleHeightChanged)));

        public static void OnExampleHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((AreaExamples)d).UpdateTemplateSettings();
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            UpdateTemplateSettings();
        }

        private void UpdateTemplateSettings()
        {
            object[] properties = new object[Enum.GetNames(typeof(AreaExamplesTemplateSettings.AreaExamplesTemplateSettingsPropertyNames)).Length];
            properties[(int)AreaExamplesTemplateSettings.AreaExamplesTemplateSettingsPropertyNames.ExampleHeight] = this.ExampleHeight;
            properties[(int)AreaExamplesTemplateSettings.AreaExamplesTemplateSettingsPropertyNames.ExampleWidth] = this.ExampleWidth;
            this.AreaExamplesTemplateSettings.MyProperties = properties;
        }
    }
}
