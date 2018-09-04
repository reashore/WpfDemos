using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OneWayDataBinding
{
    public class Employee : INotifyPropertyChanged
    {
        private string _name;
        private string _title;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        //public static Employee GetEmployee()
        //{
        //    Employee employee = new Employee
        //    {
        //        Name = "Frank",
        //        Title = "CTO"
        //    };

        //    return employee;
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
