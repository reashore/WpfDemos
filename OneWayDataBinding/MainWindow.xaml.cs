using System.Windows;

namespace OneWayDataBinding
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //DataContext = Employee.GetEmployee();

            _employee = new Employee
            {
                Name = "Frank",
                Title = "Developer"
            };

            DataContext = _employee;
        }

        private readonly Employee _employee;

        private void ChangePropertyButton_Click(object sender, RoutedEventArgs e)
        {
            _employee.Name = "Paul";
            _employee.Title = "Programmer";
        }
    }
}
