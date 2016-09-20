using System;
using System.Collections.ObjectModel;
using System.Linq;
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

        /// <summary>
        /// Initialises an instance of <see cref="MainWindowViewModel"/>.
        /// </summary>
        public MainWindowViewModel()
        {
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
            Events.Add(new EventModel("Pay Day", new DateTime(2016, 09, 28)));
            Events.Add(new EventModel("Masie BDay", new DateTime(2016, 09, 30)));
            Events.Add(new EventModel("Christmas", new DateTime(2016, 12, 25)));
            Events.Add(new EventModel("Christmas", new DateTime(2016, 12, 25)));
            Events.Add(new EventModel("Christmas", new DateTime(2016, 12, 25)));
            Events.Add(new EventModel("Christmas", new DateTime(2016, 12, 25)));

            SelectedEvent = Events.First();
        }
    }
}
