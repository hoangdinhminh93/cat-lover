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
    public partial class BreedDetailPage : BaseContentPage<BreedDetailViewModel>
    {
        public BreedDetailPage(CatBreed breed)
        {
            InitializeComponent();
            ViewModel.CatBreed = breed;
        }
    }
}