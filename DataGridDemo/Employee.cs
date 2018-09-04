using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataGridDemo
{
    public enum Party
    {
        Independent,
        Federalist,
        DemocratRepublican
    }

    public class Employee : INotifyPropertyChanged
    {
        private string _name;
        private string _title;
        private bool _wasReElected;
        private Party _affiliation;

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

        public bool WasReElected
        {
            get => _wasReElected;
            set
            {
                _wasReElected = value;
                OnPropertyChanged();
            }
        }

        public Party Affiliation
        {
            get => _affiliation;
            set
            {
                _affiliation = value;
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
                new Employee {Name = "Washington", Title = "President 1", WasReElected=true, Affiliation= Party.DemocratRepublican},
                new Employee {Name = "Adams", Title = "President 2", WasReElected=false, Affiliation= Party.Federalist},
                new Employee {Name = "Jefferson", Title = "President 3", WasReElected=true, Affiliation= Party.Independent},
                new Employee {Name = "Madison", Title = "President 4", WasReElected=false, Affiliation= Party.DemocratRepublican},
                new Employee {Name = "Monroe", Title = "President 5", WasReElected=true, Affiliation= Party.Federalist}
            };

            return employees;
        }

    }
}
