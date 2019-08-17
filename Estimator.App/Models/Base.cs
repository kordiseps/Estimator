using Estimator.App.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.App.Models
{
    public class Base
    {

        public static List<T> Get<T>(string path)
        {

            try
            {
                string raw;
                using (StreamReader streamReader = new StreamReader(path))
                {
                    raw = streamReader.ReadToEnd();
                }

                List<T> List = SerializeWorks.Deserialize<List<T>>(raw);

                return List;
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
            }
            return new List<T>();
        }


        public static bool Save<T>(List<T> List, string path)
        {

            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.Write(SerializeWorks.Serialize(List));
                }

                return true;
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
            }
            return false;
        }

    }
}
