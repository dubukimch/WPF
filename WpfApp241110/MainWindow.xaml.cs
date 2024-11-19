using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp241119
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public MainWindow ()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}