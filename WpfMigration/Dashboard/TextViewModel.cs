using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;
using WpfMigration.Messages;

namespace WpfMigration.Dashboard
{
    public class TextViewModel : PropertyChangedBase, IHandle<ChangeTextMessage>
    {
        private readonly IEventAggregator _events;

        private string _text;

        public TextViewModel(IEventAggregator events)
        {
            Text = "No button pressed";
            _events = events;
            _events.Subscribe(this);
        }

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                NotifyOfPropertyChange(() => Text);
            }
        }
        
        public Task HandleAsync(ChangeTextMessage message, CancellationToken cancellationToken)
        {
            Text = message.Text;
            return Task.CompletedTask;
        }
    }
}