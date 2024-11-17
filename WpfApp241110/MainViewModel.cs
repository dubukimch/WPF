using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace WpfApp241118
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public ICommand ShowNameCommand { get; }

        public MainViewModel ()
        {
            ShowNameCommand = new RelayCommand(ShowName);
        }

        private void ShowName ()
        {
            MessageBox.Show($"Hello, {Name}!");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
