using System.Windows;

namespace WpfApp241110
{
    public partial class App : Application
    {
        public void ChangeTheme (string theme)
        {
            var dict = new ResourceDictionary();
            switch (theme)
            {
                case "Dark":
                    dict.Source = new System.Uri("DarkTheme.xaml", System.UriKind.Relative);
                    break;
                case "Light":
                    dict.Source = new System.Uri("LightTheme.xaml", System.UriKind.Relative);
                    break;
            }

            // 기존 리소스 제거 및 새로운 테마 추가
            this.Resources.MergedDictionaries.Clear();
            this.Resources.MergedDictionaries.Add(dict);
        }
    }
}
