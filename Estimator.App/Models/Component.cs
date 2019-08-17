using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.App.Models
{
    public class Component
    {
        public string Name { get; set; }
        public decimal LongSide { get; set; }
        public decimal ShortSide { get; set; }
        public int Count { get; set; }
        public int PlatingLongSideCount { get; set; }
        public int PlatingShortSideCount { get; set; }
        public Component()
        {
            LongSide = 0;
            ShortSide = 0;
            Count = 0;
            PlatingLongSideCount = 0;
            PlatingShortSideCount = 0;

        }
        public override string ToString()
        {
            return Name + "\t\t" + 
                Count +" x " + GetFieldSize().ToString("N2") +" m2\n" +
                GetPlatingSize().ToString("N2") + " m PVC ";
        }

        public decimal GetFieldSize()
        {
            return LongSide * ShortSide;
        }
        public decimal GetPlatingSize()
        {
            return PlatingLongSideCount * LongSide + PlatingShortSideCount * ShortSide;
        }
    }
}
