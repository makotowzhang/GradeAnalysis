using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace GradeAnalysis
{
    public class JsonDataHelper
    {
        public static T GetJsonData<T>(string dataSource)
        {
            string json = "";
            using (StreamReader sr = new StreamReader(dataSource))
            {
                json = sr.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static void SaveJsonData(object data,string dataSource)
        {
            using (StreamWriter sw = new StreamWriter(dataSource))
            {
                sw.Write(JsonConvert.SerializeObject(data));
            }
        }
    }
}
