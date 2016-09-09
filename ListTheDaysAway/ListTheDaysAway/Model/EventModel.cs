namespace ListTheDaysAway.Model
{
    public class EventModel : BaseModel
    {
        private string _name;

        public EventModel(string name)
        {
            Name = name;
        }

        public string Name
        {
            get {  return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
    }
}
