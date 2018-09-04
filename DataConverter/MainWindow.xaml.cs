using System;

namespace DataConverter
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Employee employee = new Employee("Frank", "Developer", new DateTime(2018, 9, 4));
            DataContext = employee;
        }
    }
}
