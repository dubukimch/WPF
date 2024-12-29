using SynfusionWpfApp241129;
using System.Windows;

namespace SynfusionWpfApp241129
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenMapViewer_Click (object sender, RoutedEventArgs e)
        {
            MapWindow mapWindow = new MapWindow();
            mapWindow.Show();
        }

        private void OpenFileViewer_Click (object sender, RoutedEventArgs e)
        {
            FileLoadWindow excelWindow = new FileLoadWindow();
            excelWindow.Show();
        }

        private void OpenChartWindow_Click (object sender, RoutedEventArgs e)
        {
            // ChartWindow를 새 창으로 엽니다.
            ChartWindow chartWindow = new ChartWindow();
            chartWindow.Show();
        }
        private void OpenTabWindow_Click (object sender, RoutedEventArgs e)
        {
            // TabbedWindow 열기
            var tabbedWindow = new TabbedWindow();
            tabbedWindow.Show();
        }
        private void OpenNavigationDrawer_Click (object sender, RoutedEventArgs e)
        {
            SfNavigationDrawerWindow navigationDrawerWindow = new SfNavigationDrawerWindow();
            navigationDrawerWindow.Show();
        }
        private void DataGrid_Click (object sender, RoutedEventArgs e)
        {
            DataGridWindow dataGridWindow = new DataGridWindow();
            dataGridWindow.Show();
        }
    }
}
