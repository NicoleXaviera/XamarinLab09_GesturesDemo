using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GesturesDemo
{
    public partial class App : Application
    {

        public static float ScreenHeight { get; set;  }
        public static float Screenwidth { get; set; }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
