using System.Windows;
using WpfApp241110;

namespace WpfApp241121
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void SwitchToDarkTheme_Click (object sender, RoutedEventArgs e)
        {
            // Dark Theme 적용
            ((App)Application.Current).ChangeTheme("Dark");
        }

        private void SwitchToLightTheme_Click (object sender, RoutedEventArgs e)
        {
            // Light Theme 적용
            ((App)Application.Current).ChangeTheme("Light");
        }
    }
}
