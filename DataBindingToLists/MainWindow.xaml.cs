namespace DataBindingToLists
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = Employee.GetEmployees();
        }
    }
}
