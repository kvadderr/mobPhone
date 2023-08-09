using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobPhone
{
    public partial class App : Application
    {

        public static MainViewModel ViewModel { get; set; }
        public static bool isDestination { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
