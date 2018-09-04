using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataConverter
{
    public class Employee : INotifyPropertyChanged
    {
        public Employee(string name, string title, DateTime startDate)
        {
            _name = name;
            _title = title;
            _startDate = startDate;
        }

        private string _name;
        private string _title;
        private DateTime _startDate;

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

        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
