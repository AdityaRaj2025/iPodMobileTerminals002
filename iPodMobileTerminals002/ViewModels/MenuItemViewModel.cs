using iPodMobileTerminals002.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using MenuItem = iPodMobileTerminals002.Models.MenuItem;

namespace iPodMobileTerminals002.ViewModels
{
    public class MenuItemViewModel : INotifyPropertyChanged
    {
        public ICommand CountCommand => new Command(CountValues);
        
        public string Value {get;set;}
        public string _message { get; set; }
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }


        public MenuItemViewModel()
        {
            GetMenuItemData();
        }

        public async void GetMenuItemData()
        {
            using (var client = new HttpClient())
            {                        
                var uri = "https://ipodwebapiazure.azurewebsites.net/api/MenuItem/GetMenuItemData";
                var result = await client.GetStringAsync(uri);
                var MenuItemList = JsonConvert.DeserializeObject<List<Models.MenuItem>>(result);
                item = new ObservableCollection<MenuItem>(MenuItemList);
                IsRefreshing = false;
            }
        }
        

        public Command RefreshData
        {
            get
            {
                return new Command(() =>
                {
                    GetMenuItemData();

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

        ObservableCollection<MenuItem> _item;
        public ObservableCollection<MenuItem> item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CountValues()
        {
            this.Value = "Hello";
            
            //Value++;
            Message = this.Value;       
        }
        
    }
}
