using CatLover.Extensions;
using CatLover.Models;
using CatLover.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CatLover.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : BaseContentPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnViewCellTapped(object sender, EventArgs e)
        {
            if ((sender as ViewCell).BindingContext is CatBreed)
            {
                listView.SelectedItem = null;
                await App.Current.MainPage.Navigation.PushAsyncSingle(new BreedDetailPage((sender as ViewCell).BindingContext as CatBreed));
            }
        }
    }
}