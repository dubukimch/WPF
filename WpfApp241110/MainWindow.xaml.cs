using System.Windows;
using System.Windows.Input;
using WpfApp241110;

namespace WpfApp241124
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        // Window에서 터널링 이벤트 발생
        private void Window_PreviewMouseLeftButtonDown (object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Window PreviewMouseLeftButtonDown (Tunneling)");
        }

        // Grid로 이벤트 전파
        private void Grid_PreviewMouseLeftButtonDown (object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Grid PreviewMouseLeftButtonDown (Tunneling)");
        }

        // Button으로 이벤트 전파
        private void Button_PreviewMouseLeftButtonDown (object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Button PreviewMouseLeftButtonDown (Tunneling)");
        }
    }
}
