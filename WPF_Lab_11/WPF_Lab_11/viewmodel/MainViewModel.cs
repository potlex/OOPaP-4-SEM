using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Lab_11.command;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WPF_Lab_11.viewmodel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<RECORD> records;
        public ObservableCollection<RECORD> schedule;
        public ICommand addToScheduleCommand;
        public ICommand removeFromScheduleCommand;

        public ObservableCollection<RECORD> Records
        {
            get => records;
            set
            {
                records = value;
                OnPropertyChanged(nameof(Records));
            }
        }
        public ObservableCollection<RECORD> Schedule
        {
            get => schedule;
            set
            {
                schedule = value;
                OnPropertyChanged(nameof(Schedule));
            }
        }

        public int TotalCount => GetTotalCount();

        public ICommand AddToScheduleCommand
        {
            get
            {
                if (addToScheduleCommand == null)
                {
                    addToScheduleCommand = new RelayCommand(
                        param => AddToSchedule(param as RECORD),
                        param => CanAddToSchedule(param as RECORD));
                }

                return addToScheduleCommand;
            }
        }
        public ICommand RemoveFromScheduleCommand
        {
            get
            {
                if (removeFromScheduleCommand == null)
                {
                    removeFromScheduleCommand = new RelayCommand(
                        param => RemoveFromSchedule(param as RECORD),
                        param => CanRemoveFromSchedule(param as RECORD));
                }

                return removeFromScheduleCommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainViewModel()
        {
            using (var db = new ApplicationContext())
            {
                Records = new ObservableCollection<RECORD>(db.Record.ToList());
            }
            Schedule = new ObservableCollection<RECORD>();
        }

        public void AddToSchedule(RECORD record)
        {
            if (record == null)
            {
                return;
            }
            record.Free = true;
            Schedule.Add(record);
            OnPropertyChanged(nameof(TotalCount));
        }

        public bool CanAddToSchedule(RECORD record)
        {
            return record != null && !record.Free;
        }

        public void RemoveFromSchedule(RECORD record)
        {
            if (record == null)
            {
                return;
            }
            record.Free = false;
            Schedule.Remove(record);
            OnPropertyChanged(nameof(TotalCount));
        }

        public bool CanRemoveFromSchedule(RECORD record)
        {
            return record != null && record.Free;
        }

        public int GetTotalCount()
        {
            return Schedule.Count();
        }
    }
}
