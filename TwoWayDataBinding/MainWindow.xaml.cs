namespace TwoWayDataBinding
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Employee employee = new Employee
            {
                Name = "Frank",
                Title = "Developer"
            };

            DataContext = employee;
        }
    }
}
