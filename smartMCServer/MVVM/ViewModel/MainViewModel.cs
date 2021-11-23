using smartMCServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartMCServer.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ConsoleViewCommand { get; set; }
        public RelayCommand PlayersViewCommand { get; set; }
        public RelayCommand WorldsViewCommand { get; set; }
        public RelayCommand BackupsViewCommand { get; set; }
        public RelayCommand TaskSchedulerViewCommand { get; set; }
        public RelayCommand ServerConfigViewCommand { get; set; }
        public RelayCommand SMCSSettingsViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public ConsoleViewModel ConsoleVM { get; set; }
        public PlayersViewModel PlayersVM { get; set; }
        public WorldsViewModel WorldsVM { get; set; }
        public BackupsViewModel BackupsVM { get; set; }
        public TaskSchedulerViewModel TaskSchedulerVM { get; set; }
        public ServerConfigViewModel ServerConfigVM { get; set; }
        public SMCSSettingsViewModel SMCSSettingsVM { get; set; }

        private object  _currentView;

        public object  CurrentView
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

            ConsoleVM = new ConsoleViewModel();

            PlayersVM = new PlayersViewModel();

            WorldsVM = new WorldsViewModel();

            BackupsVM = new BackupsViewModel();

            TaskSchedulerVM = new TaskSchedulerViewModel();

            ServerConfigVM = new ServerConfigViewModel();

            SMCSSettingsVM = new SMCSSettingsViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            { 
                CurrentView = HomeVM;
            });

            ConsoleViewCommand = new RelayCommand(o =>
            {
                CurrentView = ConsoleVM;
            });

            PlayersViewCommand = new RelayCommand(o =>
            {
                CurrentView = PlayersVM;
            });

            WorldsViewCommand = new RelayCommand(o =>
            {
                CurrentView = WorldsVM;
            });

            BackupsViewCommand = new RelayCommand(o =>
            {
                CurrentView = BackupsVM;
            });

            TaskSchedulerViewCommand = new RelayCommand(o =>
            {
                CurrentView = TaskSchedulerVM;
            });

            ServerConfigViewCommand = new RelayCommand(o =>
            {
                CurrentView = ServerConfigVM;
            });

            SMCSSettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SMCSSettingsVM;
            });
        }



    }
    }