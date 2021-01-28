using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal class Chocolate : Milkshake
    {
        public enum typeOfChocolate
        {
            White = 1,
            Milk = 2,
            Dark = 3,
        };

        public typeOfChocolate TypeOfChocolate { get; set; }

        public Chocolate(bool hasDairy = false, bool hasWhippedCream = false, typeOfChocolate typeOfChocolate = typeOfChocolate.Milk)
            : base(hasDairy, hasWhippedCream)
        {
            TypeOfChocolate = typeOfChocolate;
            Name = "Chocolate Shake";
            Price = 5.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\chocolate.jpg";
            Description = "Three simple ingredients are all it takes to make an easy homemade chocolate milkshake. Vanilla ice cream, ice cold milk, HERSHEY'S Syrup. Blend, pour, sip.";
        }
    }
}