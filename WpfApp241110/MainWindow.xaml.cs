using System.Windows;

namespace WpfApp241118
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