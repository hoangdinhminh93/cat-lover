using CatLover.Utilities;

namespace CatLover.ViewModels
{
    public class BaseViewModel : Notifiable
    {
        public bool IsBusy { get; set; }

        public virtual void OnAppearing() { }

        public virtual void OnDisappearing() { }

        public virtual void Initialize() { }
    }
}