using Estimator.App.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.App.Models
{
    public class RawMaterial :Base
    {
        public const string RawMaterialsPath = @"\File\RawMaterials.xml";

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public static bool Add(RawMaterial rawMaterial)
        {

            try
            {
                List<RawMaterial> List = Get<RawMaterial>(RawMaterialsPath);

                List.Add(rawMaterial);

                return Save<RawMaterial>(List, RawMaterialsPath);
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
            }
            return false;
        }

        public static bool Remove(RawMaterial rawMaterial)
        {
            try
            {
                List<RawMaterial> List = Get<RawMaterial>(RawMaterialsPath);

                List.RemoveAll(x => x.Name == rawMaterial.Name && x.UnitPrice == rawMaterial.UnitPrice);

                return Save<RawMaterial>(List, RawMaterialsPath);
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
            }
            return false;
        }

        //public static bool Save(List<RawMaterial> List)
        //{

        //    try
        //    {
        //        using (StreamWriter streamWriter = new StreamWriter(RawMaterialsPath))
        //        {
        //            streamWriter.Write(SerializeWorks.Serialize(List));
        //        }

        //        return true;
        //    }
        //    catch (Exception aa)
        //    {
        //        Console.WriteLine(aa.Message);
        //    }
        //    return false;
        //}

        //public static List<RawMaterial> Get()
        //{

        //    try
        //    {
        //        string raw;
        //        using (StreamReader streamReader = new StreamReader(RawMaterialsPath))
        //        {
        //            raw = streamReader.ReadToEnd();
        //        }

        //        List<RawMaterial> List = SerializeWorks.Deserialize<List<RawMaterial>>(raw);

        //        return List;
        //    }
        //    catch (Exception aa)
        //    {
        //        Console.WriteLine(aa.Message);
        //    }
        //    return null;
        //}

        public override string ToString()
        {
            return Name + " : " + UnitPrice.ToString("N2");
        }
    }
}
