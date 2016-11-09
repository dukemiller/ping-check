using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ping_check
{
    internal sealed class MainWindowViewModel: INotifyPropertyChanged
    {
        private const string Template = "Ping: {0}ms";

        private string _text;

        // 

        public MainWindowViewModel()
        {
            Text = string.Format(Template, "??");
        }

        // 

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        // 

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
