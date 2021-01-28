using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal abstract class Coffee : Beverage
    {
        public int Caffeine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        protected Coffee()

        {
            //Caffeine = caffeine;
            //HasMilk = hasMilk;
            //HasSugar = hasSugar;
        }
        //int caffeine, bool hasMilk, bool hasSugar
    }
}