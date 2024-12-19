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

        private void OpenExcelViewer_Click (object sender, RoutedEventArgs e)
        {
            FileLoadWindow excelWindow = new FileLoadWindow();
            excelWindow.Show();
        }

        //private void OpenPptViewer_Click (object sender, RoutedEventArgs e)
        //{
        //    PptWindow pptWindow = new PptWindow();
        //    pptWindow.Show();
        //}
    }
}
