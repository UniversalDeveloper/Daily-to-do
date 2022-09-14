using DailyList.DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyList.DataSaving
{ 
    class FileIOService
    {  public readonly string PATH;
        public FileIOService(string path) 
        { PATH = path;
        }      
        public void SaveData(BindingList<DataModelOfDailyList> containerForListCases)
        {
            using (StreamWriter saveToFile = File.CreateText(PATH))
            {
                var saveInFile = JsonConvert.SerializeObject(containerForListCases);
                saveToFile.Write(saveInFile);
            }
         }

    }
}
