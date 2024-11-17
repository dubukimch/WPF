using System.Windows;
namespace WpfApp241120
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
