using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop.Product_Milkshake
{
    internal class Vanilla : Milkshake
    {
        public Vanilla(bool hasDairy, bool hasWhippedCream)
            : base(hasDairy, hasWhippedCream)
        {
            Name = "Vanilla Shake";
            Price = 5.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\vanilla.jpg";
            Description = "A milkshake, or simply shake, is a drink that is traditionally made by blending cow's milk, ice cream, and flavorings or sweeteners such as butterscotch, caramel sauce, chocolate syrup, fruit syrup, or whole fruit into a thick, sweet, cold mixture.";
        }
    }
}