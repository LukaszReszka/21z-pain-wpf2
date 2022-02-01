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
public partial class MyCarouselPage : CarouselPage
{
    public MyCarouselPage()
    {
        InitializeComponent();

            this.Children.Add(new MainPage());
            this.Children.Add(new RectangleFieldPage());
            this.Children.Add(new ConverterPage());
    }
}
}