using iPodMobileTerminals002.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace iPodMobileTerminals002.ViewModels
{
    public class CategoryViewModel : INotifyPropertyChanged
    {
      
        public CategoryViewModel()
        {
            GetMajorCategoryData();
            GetMinorCategoryData();
        }

        public async void GetMajorCategoryData()
        {
             using (var client = new HttpClient())
             {
                // send a GET request              
                var uri = "http://localhost:3001/api/MajorCategory/GetMajorCategoryData";              
                var result = await client.GetStringAsync(uri);
                var MajorCategoryList = JsonConvert.DeserializeObject<List<MajorCategory>>(result);
                major = new ObservableCollection<MajorCategory>(MajorCategoryList);
                IsRefreshing = false;
             }          
        }

        public async void GetMinorCategoryData()
        {
            using (var client = new HttpClient())
            {
                // send a GET request              
                var uri = "http://localhost:3001/api/MinorCategory/GetMinorCategoryData";
               
                var result = await client.GetStringAsync(uri);
                var MinorCategoryList = JsonConvert.DeserializeObject<List<MinorCategory>>(result);
                minor = new ObservableCollection<MinorCategory>(MinorCategoryList);
                IsRefreshing = false;
            }
        }

        

        ObservableCollection<MajorCategory> _majorCategorys;
        public ObservableCollection<MajorCategory> major
        {
            get
            {
                return _majorCategorys;
            }
            set
            {
                _majorCategorys = value;
                OnPropertyChanged();
            }
        }

        ObservableCollection<MinorCategory> _minorCategorys;
        public ObservableCollection<MinorCategory> minor
        {
            get
            {
                return _minorCategorys;
            }
            set
            {
                _minorCategorys = value;
                OnPropertyChanged();
            }
        }

        public Command RefreshData
        {
            get
            {
                return new Command(() =>
                {
                    GetMajorCategoryData();
                    GetMinorCategoryData();

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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
