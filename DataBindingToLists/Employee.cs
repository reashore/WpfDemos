using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingToLists
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>
            {
                new Employee {Name = "Washington", Title = "President 1"},
                new Employee {Name = "Adams", Title = "President 2"},
                new Employee {Name = "Jefferson", Title = "President 3"},
                new Employee {Name = "Madison", Title = "President 4"},
                new Employee {Name = "Monroe", Title = "President 5"}
            };

            return employees;
        }
    }
}
