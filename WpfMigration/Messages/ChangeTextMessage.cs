namespace WpfMigration.Messages
{
    public class ChangeTextMessage
    {
        public string Text
        {
            get;
            private set;
        }
 
        public ChangeTextMessage(string text)
        {
            Text = text;
        }
    }
}
