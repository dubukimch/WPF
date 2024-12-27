using Syncfusion.UI.Xaml.NavigationDrawer;
using System.Windows;
using System.Windows.Controls;


namespace SynfusionWpfApp241129
{
    /// <summary>
    /// SfNavigationDrawerWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SfNavigationDrawerWindow : Window
    {
        public SfNavigationDrawerWindow()
        {
            InitializeComponent();
        }
        private void NavigationDrawer_ItemClicked (object sender, NavigationItemClickedEventArgs e)
        {
            if (e.Item is NavigationItem selectedItem)
            {
                string tag = selectedItem.Tag?.ToString();
                UserControl control = tag switch
                {
                    "Home" => new HomeControl(),      // 실제 Home UserControl
                    "Settings" => new SettingsControl(), // 실제 Settings UserControl
                    _ => null
                };

                if (control != null)
                {
                    contentViewGrid.Children.Clear();
                    contentViewGrid.Children.Add(control);
                }
            }
        }
    }
}
