using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Lib
{
    public class JsonHandler
    {
        public string Serialize<T>(List<T> inputList)
        {
            string outputJson = "";
            outputJson = JsonConvert.SerializeObject(inputList);
            return outputJson;
        }
        public string SerializeObject<T>(T inputObject)
        {
            string outputJson = "";
            outputJson = JsonConvert.SerializeObject(inputObject);
            return outputJson;
        }
        public T Deserialize<T>(string jsonString)
        {
            T returnList= JsonConvert.DeserializeObject<T>(jsonString);
            return returnList;
        }
    }
}
