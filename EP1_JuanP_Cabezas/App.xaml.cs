using EP1_JuanP_Cabezas.Services;
using EP1_JuanP_Cabezas.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EP1_JuanP_Cabezas
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
