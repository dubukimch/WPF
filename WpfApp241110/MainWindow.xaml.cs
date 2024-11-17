using System.Windows;

namespace WpfApp241117
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void Button_Click (object sender, RoutedEventArgs e)
        {
            MessageBox.Show("버튼이 클릭되었습니다!");
        }
    }
}