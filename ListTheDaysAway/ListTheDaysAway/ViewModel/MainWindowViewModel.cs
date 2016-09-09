using System;
using System.Collections.ObjectModel;
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

        private void PopulateEvents()
        {
            Events.Add(new EventModel("Christmas", new DateTime(2016, 12, 25)));
        }
    }
}
