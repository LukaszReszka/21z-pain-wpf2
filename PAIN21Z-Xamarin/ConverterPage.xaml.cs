using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAIN21Z_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConverterPage : ContentPage
    {
        public ConverterPage()
        {
            InitializeComponent();
            chosen_numb.BindingContext = slider;
            chosen_numb.SetBinding(Span.TextProperty, "Value");
        }

        void OnSliderValChanged(object sender, TextChangedEventArgs e)
        {
            double cm = slider.Value * 2.54;
            result.Text = cm.ToString();
        }
    }
}