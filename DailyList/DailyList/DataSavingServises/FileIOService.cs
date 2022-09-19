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
        public BindingList<DataModelOfDailyList> LoudData()
        {
            var fileExist = File.Exists(PATH);
            if (!fileExist)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<DataModelOfDailyList>();
            }
            using (var readStringFromFile = File.OpenText(PATH))
            {
                string textFromFile = readStringFromFile.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<DataModelOfDailyList>>(textFromFile);
            }
        }

    }
}
