namespace DataGridDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            EmployeeDataGrid.ItemsSource = Employee.GetEmployees();
        }
    }
}
