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
public partial class RectangleFieldPage : ContentPage
{
    public RectangleFieldPage()
    {
        InitializeComponent();
    }

      void  OnEntryAValChanged(object sender, TextChangedEventArgs e)
       {
            A = e.NewTextValue;
       }

        void OnEntryBValChanged(object sender, TextChangedEventArgs e)
        {
            B = e.NewTextValue;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            double res = 0;

            if(Double.TryParse(A, out x) && Double.TryParse(B, out y) && x > 0 && y > 0)
            {
                res = x * y;
                result.Text = res.ToString();
            }
            else 
                result.Text = "Nieprawidłowe wartości długości boków!!!";
        }

        public String A { get; set; }
        public String B { get; set; }

}
}