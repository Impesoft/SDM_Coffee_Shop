using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SDM_Coffee_Shop
{ 
    internal class Espresso : Coffee
    {
        public typeOfRoast TypeOfRoast { get; set; }

        public Espresso(int caffeine = 0, bool hasMilk = false, bool hasSugar = false, typeOfRoast typeOfRoast = typeOfRoast.Medium)
            : base(caffeine, hasMilk, hasSugar)
        {
            TypeOfRoast = typeOfRoast;
            Name = "Espresso";
            Price = 2.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\espresso.jpg";
            Description = "Espresso is a coffee-brewing method of Italian origin, in which a small amount of nearly boiling water is forced under 9–10 bars of atmospheric pressure through finely-ground coffee beans. Espresso coffee can be made with a wide variety of coffee beans and roast degrees.";
        }
    }
}