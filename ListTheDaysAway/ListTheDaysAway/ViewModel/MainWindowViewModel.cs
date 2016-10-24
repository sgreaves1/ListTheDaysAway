using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ListTheDaysAway.Command;
using ListTheDaysAway.Model;

namespace ListTheDaysAway.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        /// <summary>
        /// List of events to display to the user.
        /// </summary>
        private ObservableCollection<EventModel> _events = new ObservableCollection<EventModel>();

        /// <summary>
        /// The current event that is selected.
        /// </summary>
        private EventModel _selectedEvent;

        private int _selectedIndex;

        /// <summary>
        /// Initialises an instance of <see cref="MainWindowViewModel"/>.
        /// </summary>
        public MainWindowViewModel()
        {
            _selectedIndex = 0;

            InitCommands();

            PopulateEvents();
        }

        /// <summary>
        /// List of events to display to the user.
        /// </summary>
        public ObservableCollection<EventModel> Events
        {
            get { return _events; }
            set
            {
                _events = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The current event that is selected.
        /// </summary>
        public EventModel SelectedEvent
        {
            get {  return _selectedEvent; }
            set
            {
                _selectedEvent = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Generate a list of events. 
        /// </summary>
        private void PopulateEvents()
        {
            Events.Add(new EventModel("Chimney Opened", new DateTime(2016, 11, 12)));
            Events.Add(new EventModel("Christmas", new DateTime(2016, 12, 25)));

            SelectedEvent = Events[_selectedIndex];
        }

        public ICommand NextCommand { get; set; }
        public ICommand BackCommand { get; set; }

        private void InitCommands()
        {
            NextCommand = new RelayCommand(ExecuteNextCommand, CanExecuteNextCommand);
            BackCommand = new RelayCommand(ExecuteBackCommand, CanExecuteBackCommand);
        }

        private bool CanExecuteBackCommand()
        {
            if (_selectedIndex > 0)
                return true;

            return false;
        }

        private void ExecuteBackCommand()
        {
            _selectedIndex--;

            SelectedEvent = Events[_selectedIndex];
        }

        private bool CanExecuteNextCommand()
        {
            if (_selectedIndex < (Events.Count - 1))
                return true;

            return false;
        }

        private void ExecuteNextCommand()
        {
            _selectedIndex++;

            if (_selectedIndex < Events.Count)
            {
                SelectedEvent = Events[_selectedIndex];
            }
            else
            {
                _selectedIndex--;
            }
        }
    }
}
