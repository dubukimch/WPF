using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp241113
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private User _selectedUser;
        public ObservableCollection<User> UserList { get; set; }

        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        public MainWindow ()
        {
            InitializeComponent();
            UserList = new ObservableCollection<User>
            {
                new User { ID = 1, Name = "John Doe", Email = "john.doe@example.com", Phone = "123-456-7890" },
                new User { ID = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Phone = "098-765-4321" },
                new User { ID = 3, Name = "Bob Johnson", Email = "bob.johnson@example.com", Phone = "555-123-4567" }
            };
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
