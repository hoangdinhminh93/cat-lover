using CatLover.Extensions;
using CatLover.Http;
using CatLover.Models;
using CatLover.Services;
using System.Collections.ObjectModel;

namespace CatLover.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ICatService catService;

        public MainViewModel(ICatService catService)
        {
            this.catService = catService;
        }

        public ObservableCollection<CatBreed> CatBreeds { get; set; } = new ObservableCollection<CatBreed>();

        public override void OnAppearing()
        {
            base.OnAppearing();
            CatBreeds = catService.SearchAllBreeds().ToObservableCollection();
        }
    }
}