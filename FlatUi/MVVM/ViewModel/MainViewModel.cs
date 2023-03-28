using FlatUi.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatUi.MVVM.ViewModel
{
    internal class MainViewModel:ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoverViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoverViewModel DiscoverVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoverVM = new DiscoverViewModel();
            _currentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            DiscoverViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoverVM;
            });
        }
    }
}
