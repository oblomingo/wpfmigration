using Caliburn.Micro;

namespace WpfMigration.Dashboard
{
    public class ShellViewModel : PropertyChangedBase
    {
        IEventAggregator events = new EventAggregator();

        private string _message;
 
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }
 
        private int _pressCount;

        public ButtonsViewModel ButtonsVM
        {
            get;
            set;
        }
 
        public TextViewModel TextVM
        {
            get;
            set;
        }
 
        public ShellViewModel()
        {
            Message = "Hello World";
            _pressCount = 0;
            ButtonsVM = new ButtonsViewModel(events);
            TextVM = new TextViewModel(events);
        }
 
        public void ChangeMessage(int incrementBy)
        {
            _pressCount += incrementBy;
 
            Message = "Presses = " + _pressCount;
        }
    }
}