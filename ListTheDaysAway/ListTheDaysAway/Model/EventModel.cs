using System;

namespace ListTheDaysAway.Model
{
    public class EventModel : BaseModel
    {
        /// <summary>
        /// The name of the event.
        /// </summary>
        private string _name;

        /// <summary>
        /// The date the event occurs.
        /// </summary>
        private DateTime _endDate;

        /// <summary>
        /// Initialises an instance of <see cref="EventModel"/>.
        /// </summary>
        /// <param name="name">The name of the event.</param>
        /// <param name="endDate">The date the event occurs.</param>
        public EventModel(string name, DateTime endDate)
        {
            Name = name;
            EndDate = endDate;
        }

        /// <summary>
        /// The name of this event.
        /// </summary>
        public string Name
        {
            get {  return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// The date this event occurs.
        /// </summary>
        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                OnPropertyChanged();
            }
        }
    }
}
