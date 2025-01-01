using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Syncfusion.SfSkinManager;

namespace SynfusionWpfApp241129
{
    /// <summary>
    /// ThemeSelectorWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ThemeSelectorWindow : Window
    {
        public ThemeSelectorWindow ()
        {
            InitializeComponent();
        }

        private void ApplyThemeButton_Click (object sender, RoutedEventArgs e)
        {
            var selectedTheme = (ThemeListBox.SelectedItem as ListBoxItem)?.Content.ToString();
            if (!string.IsNullOrEmpty(selectedTheme))
            {
                // Main Window에 테마 적용
                var mainWindow = Application.Current.MainWindow;
                SfSkinManager.SetTheme(mainWindow, new Syncfusion.SfSkinManager.Theme() { ThemeName = selectedTheme });
                MessageBox.Show($"Theme changed to {selectedTheme}", "Theme Applied", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}
