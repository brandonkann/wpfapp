using System;
using WpfApp1.Core;

namespace WpfApp1.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TimerViewCommand { get; set; }


        public HomeViewModel HomeVm{ get; set; }

        public TimerViewModel TimerVM{ get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {
                _currentView = value;
                onPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            TimerVM = new TimerViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            TimerViewCommand = new RelayCommand(o =>
            {
                CurrentView = TimerVM;
            });

        }
    }
}
