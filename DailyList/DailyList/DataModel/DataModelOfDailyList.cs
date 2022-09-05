using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyList.DataModel
{
    class DataModelOfDailyList : INotifyPropertyChanged 
    {
        private bool isDone;
        private string textOfTasc;
        public DateTime CreationData { get; set; } = DateTime.Now;      

        public bool IsDone
        {
            get { return isDone; }
            set 
            { 
                    if (isDone == value) return;
                isDone = value;
                OnPropertyChanged("IsDone");
            }
        }        

        public string TextOfTasc
        {
            get { return textOfTasc; }
            set
            {
                if (textOfTasc == value) return;
                
                textOfTasc = value;
                OnPropertyChanged("TextOfTasc");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName= "")
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
