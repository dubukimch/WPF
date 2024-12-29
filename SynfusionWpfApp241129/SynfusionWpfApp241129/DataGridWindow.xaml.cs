using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SynfusionWpfApp241129
{
    /// <summary>
    /// DataGridWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DataGridWindow : Window
    {
        public DataGridWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
    public class MainViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public MainViewModel ()
        {
            Employees = new ObservableCollection<Employee>
            {
                new Employee { ID = 1, Name = "John Doe", Age = 30, Department = "HR" },
                new Employee { ID = 2, Name = "Jane Smith", Age = 25, Department = "Finance" },
                new Employee { ID = 3, Name = "Sam Wilson", Age = 28, Department = "IT" }
            };
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
}
