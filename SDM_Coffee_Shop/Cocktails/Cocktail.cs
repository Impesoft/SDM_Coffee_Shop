using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal class Cocktail : Beverage
    {
        public bool hasIce { get; set; }

        public int PercentageAlcohol { get; set; }

        protected Cocktail()
        {
        }
    }
}