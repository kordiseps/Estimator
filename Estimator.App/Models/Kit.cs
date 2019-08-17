using Estimator.App.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.App.Models
{
    public class Kit : Base
    {
        public const string KitsPath = @"\File\Kits.xml";

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        public static bool Add(Kit kit)
        {

            try
            {
                List<Kit> List = Get<Kit>(KitsPath);

                List.Add(kit);

                return Save(List, KitsPath);
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
            }
            return false;
        }

        public static bool Remove(Kit kit)
        {
            try
            {
                List<Kit> List = Get<Kit>(KitsPath);

                List.RemoveAll(x => x.Name == kit.Name && x.UnitPrice == kit.UnitPrice);

                return Save(List, KitsPath);
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
            }
            return false;
        }

      

        public override string ToString()
        {
            return Name + " : " + UnitPrice.ToString("N2");
        }
    }
}
