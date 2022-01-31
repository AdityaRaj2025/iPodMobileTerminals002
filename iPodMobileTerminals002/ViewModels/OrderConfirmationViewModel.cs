using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace iPodMobileTerminals002.ViewModels
{
    public class OrderConfirmationViewModel : INotifyPropertyChanged
    {
        public OrderConfirmationViewModel()
        {
            IncreaseCommand = new Command(IncreaseCount);
            DecreaseCommand = new Command(DecreaseCount);
        }

        public ICommand IncreaseCommand { get; }
        public ICommand DecreaseCommand { get; }
        int count = 0;

        void IncreaseCount()
        {
            count++;
            OnPropertyChanged(nameof(DisplayCount));
        }
        void DecreaseCount()
        {
            count--;
            OnPropertyChanged(nameof(DisplayCount));
        }

        public string DisplayCount => $" {count} ";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
