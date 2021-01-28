using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal abstract class Milkshake : Beverage
    {
        public bool HasDairy { get; set; }
        public bool HasWhippedCream { get; set; }

        public Milkshake(bool hasDairy, bool hasWhippedCream)

        {
            HasDairy = hasDairy;
            HasWhippedCream = hasWhippedCream;
        }
    }
}