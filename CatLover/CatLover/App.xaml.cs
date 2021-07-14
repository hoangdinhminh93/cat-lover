using CatLover.Pages;
using CatLover.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CatLover
{
    public partial class App : Application
    {
        public static AppContainer Container { get; set; } = new AppContainer();

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
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
