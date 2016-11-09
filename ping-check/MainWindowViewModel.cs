using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ping_check
{
    internal sealed class MainWindowViewModel : INotifyPropertyChanged
    {
        private const string Template = "Ping: {0}ms";

        private readonly IPingService _ping;

        private string _text;

        // 

        public MainWindowViewModel(IPingService ping)
        {
            _ping = ping;
            Text = string.Format(Template, "??");
            Main();
        }

        public MainWindowViewModel() : this(new PingService()) {}

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

        public async void Main()
        {
            while (true)
            {
                Text = string.Format(Template, await _ping.GetPing());
                await Task.Delay(2000);
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}