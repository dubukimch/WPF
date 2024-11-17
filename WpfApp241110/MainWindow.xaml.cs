using System.Windows;

namespace WpfApp241119
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
