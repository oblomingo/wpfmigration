using Caliburn.Micro;

namespace WpfMigration.Dashboard
{
    public class ShellViewModel : PropertyChangedBase
    {
        private string _message;

        private int _pressCount;
        private readonly IEventAggregator events = new EventAggregator();

        public ShellViewModel()
        {
            Message = "Hello World";
            _pressCount = 0;
            ButtonsVM = new ButtonsViewModel(events);
            TextVM = new TextViewModel(events);
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }

        public ButtonsViewModel ButtonsVM { get; set; }

        public TextViewModel TextVM { get; set; }

        public void ChangeMessage(int incrementBy)
        {
            _pressCount += incrementBy;
            Message = "Presses = " + _pressCount;
        }
    }
}