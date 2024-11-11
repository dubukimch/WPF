using System.Windows;

namespace WpfApp241111
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel { UserName = "Initial Name" };
        }
    }
}
