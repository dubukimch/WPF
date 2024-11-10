using System.Windows;

namespace WpfApp241110
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