using System.Windows;
using System.Windows.Controls;
using Syncfusion.Windows.Tools.Controls;

namespace SynfusionWpfApp241129
{
    public partial class TabbedWindow : Window
    {
        public TabbedWindow ()
        {
            InitializeComponent();
        }

        private void AddTab_Click (object sender, RoutedEventArgs e)
        {
            // 새로운 탭 추가
            var newTab = new TabItemExt
            {
                Header = $"Tab {TabControl.Items.Count + 1}",
                Content = new TextBlock
                {
                    Text = $"Content of Tab {TabControl.Items.Count + 1}",
                    Margin = new Thickness(10)
                }
            };
            TabControl.Items.Add(newTab);
        }

        private void RemoveTab_Click (object sender, RoutedEventArgs e)
        {
            // 선택된 탭 제거
            if (TabControl.SelectedItem != null)
            {
                TabControl.Items.Remove(TabControl.SelectedItem);
            }
            else
            {
                MessageBox.Show("No tab selected to remove.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
