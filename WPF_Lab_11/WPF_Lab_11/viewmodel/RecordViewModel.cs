using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Lab_11.viewmodel
{
    public class RecordViewModel : INotifyPropertyChanged
    {
        public RECORD Record;
        public RecordViewModel(RECORD record)
        {
            this.Record = record;
        }
        public string Fio
        {
            get { return Record.FIO; }
            set
            {
                Record.FIO = value;
                OnPropertyChanged("FIO");
            }
        }
        public string Subject
        {
            get { return Record.SUBJECT; }
            set
            {
                Record.SUBJECT = value;
                OnPropertyChanged("Subject");
            }
        }
        public DateTime Date
        {
            get { return Record.DATE; }
            set
            {
                Record.DATE = value;
                OnPropertyChanged("Date");
            }
        }
        public TimeSpan Time
        {
            get { return Record.TIME; }
            set
            {
                Record.TIME = value;
                OnPropertyChanged("Start Time");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
