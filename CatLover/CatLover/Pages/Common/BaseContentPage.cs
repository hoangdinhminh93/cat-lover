using CatLover.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace CatLover.Pages
{
    public class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            On<iOS>().SetUseSafeArea(true);
            BackgroundColor = Color.FromHex("#FFFFFF");
        }
    }

    public class BaseContentPage<T> : BaseContentPage where T : BaseViewModel
    {
        protected T ViewModel { get; set; }

        public BaseContentPage()
        {
            // Create ViewModel
            ViewModel = App.Container.Resolve<T>();
            ViewModel.Initialize();

            // Init ContentPage
            BindingContext = ViewModel;
            Title = ViewId.Title[GetType()];
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ViewModel.OnDisappearing();
        }
    }
}