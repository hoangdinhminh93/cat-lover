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
            ageLabel.PropertyChanged += (o, e) => 
            {
                if (e.PropertyName == Label.FormattedTextProperty.PropertyName)
                    System.Diagnostics.Debug.WriteLine("TextChanged");
            };
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            ViewModel.CatBreed.Age += 1;
        }
    }
}