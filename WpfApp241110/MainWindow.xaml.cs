// MainWindow.xaml.cs
using System.Windows;
using System.Windows.Controls;

namespace WpfApp241121
{
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();

            myItemsControl.Items.Add("Item A");
            myItemsControl.Items.Add("Item B");
            myItemsControl.Items.Add("Item C");
        }
    }
}
