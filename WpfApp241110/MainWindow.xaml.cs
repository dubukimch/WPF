using System.Windows;

namespace WpfApp241119
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void OnButtonClick (object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }
    }
}
