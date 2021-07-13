using CatLover.Extensions;
using CatLover.Http;
using CatLover.Models;
using System.Collections.ObjectModel;

namespace CatLover.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<CatBreed> CatBreeds { get; set; } = new ObservableCollection<CatBreed>();

        public override async void OnAppearing()
        {
            base.OnAppearing();
            var data = await DataClient.Create().GetAllBreads();
            if (data != null)
            {
                CatBreeds = data.ToObservableCollection();
            }
            else
            {
                CatBreeds.Clear();
            }
        }
    }
}