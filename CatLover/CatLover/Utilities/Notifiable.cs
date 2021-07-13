using System.ComponentModel;

namespace CatLover.Utilities
{
    public class Notifiable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}