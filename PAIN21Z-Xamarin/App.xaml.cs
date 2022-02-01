using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PAIN21Z_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyCarouselPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
