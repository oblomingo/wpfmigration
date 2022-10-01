using Caliburn.Micro;
using WpfMigration.Messages;

namespace WpfMigration.Dashboard
{
    public class ButtonsViewModel
    {
        private readonly IEventAggregator _events;

        public ButtonsViewModel(IEventAggregator events)
        {
            _events = events;
        }

        public void Button1()
        {
            _events.PublishOnUIThread(new ChangeTextMessage("Button 1 Pressed"));
        }

        public void Button2()
        {
            _events.PublishOnUIThread(new ChangeTextMessage("Button 2 Pressed"));
        }

        public void Button3()
        {
            _events.PublishOnUIThread(new ChangeTextMessage("Button 3 Pressed"));
        }
    }
}