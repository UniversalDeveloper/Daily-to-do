using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyList.DataModel
{
    class DataModelOfDailyList
    {
        private bool isDone;
        private string textOfTasc;
        public DateTime CreationData { get; set; } = DateTime.Now;      

        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }        

        public string TextOfTasc
        {
            get { return textOfTasc; }
            set { textOfTasc = value; }
        }


    }
}
