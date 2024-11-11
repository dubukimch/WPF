using System.Windows;
using WpfApp241111;

namespace WpfApp241111
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow ()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            this.DataContext = _viewModel;
        }

        private void AddItem_Click (object sender, RoutedEventArgs e)
        {
            _viewModel.AddItem("New Item");
        }

        private void RemoveItem_Click (object sender, RoutedEventArgs e)
        {
            if (_viewModel.Items.Count > 0)
            {
                _viewModel.RemoveItem(_viewModel.Items[0]); // 첫 번째 항목을 제거
            }
        }
    }
}
