using PropertyChanged;
using System.ComponentModel;

namespace CatLover.Utilities
{
    public class CustomNotify : DoNotNotifyAttribute
    {

    }

    public class Notifiable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}