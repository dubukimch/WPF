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

            myItemsControl.Items.Add("Item 1");
            myItemsControl.Items.Add("Item 2");
            myItemsControl.Items.Add("Item 3");
        }
    }
}