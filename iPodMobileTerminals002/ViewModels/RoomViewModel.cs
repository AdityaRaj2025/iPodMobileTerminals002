using iPodMobileTerminals002.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace iPodMobileTerminals002.ViewModels
{
    public class RoomViewModel : INotifyPropertyChanged
    {

        public RoomViewModel()
        {
            GetRoomStatus();          
        }

        public async void GetRoomStatus()
        {
            using (var client = new HttpClient())
            {
                // send a GET request              
                var uri = "http://localhost:3001/api/Room/GetRoomStatus";
                var result = await client.GetStringAsync(uri);
                var RoomList = JsonConvert.DeserializeObject<List<Room>>(result);
                room = new ObservableCollection<Room>(RoomList);
                IsRefreshing = false;
            }
        }

        ObservableCollection<Room> _roomStatus;
        public ObservableCollection<Room> room
        {
            get
            {
                return _roomStatus;
            }
            set
            {
                _roomStatus = value;
                OnPropertyChanged();
            }
        }

        public Command RefreshData
        {
            get
            {
                return new Command(() =>
                {
                    GetRoomStatus();

                });
            }
        }

        bool _isRefreshing;
        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        /* public class StringToColorConverter : IValueConverter
         {
             public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
             {
                 string status = (string)value;
                 if (status != null)
                 {
                     if (status == "Booked")
                     {
                         return Color.Yellow;
                     }
                     else
                     {
                         return Color.Orange;
                     }
                 }
                 return Color.Orange;
             }
             public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
             {
                 throw new NotImplementedException();
             }
         }*/

        public class YesNoMaybeToColorConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                switch (value)
                {
                    case "Booked":
                        return Color.Red;
                    case "Avilable":
                        return Color.Blue;                       
                }
                return Color.Yellow;
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                // You probably don't need this, this is used to convert the other way around
                // so from color to yes no or maybe
                throw new NotImplementedException();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
