using System.Windows;
using System.Windows.Controls;

namespace WpfApp241119
{
    public partial class UserInfoControl : UserControl
    {
        public UserInfoControl ()
        {
            InitializeComponent();
        }

        private void OnSubmitClick (object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"User Name: {UserNameTextBox.Text}");
        }
    }
}
