using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

public class MainViewModel : INotifyPropertyChanged
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged();
        }
    }

    public ICommand ShowNameCommand { get; }

    public MainViewModel ()
    {
        // 명령을 초기화할 때, 실행할 메서드를 전달
        ShowNameCommand = new RelayCommand(ShowName);
    }

    private void ShowName ()
    {
        MessageBox.Show($"Hello, {Name}!");
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged ([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
