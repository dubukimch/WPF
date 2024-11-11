using System.Windows;
namespace WpfApp241110
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
            // DataContext를 ViewModel 인스턴스로 설정
            this.DataContext = new MainViewModel { Text = "Hello, DataContext!" };
        }
    }
}
