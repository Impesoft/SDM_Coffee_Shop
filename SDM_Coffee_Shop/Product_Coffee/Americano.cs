using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal class Americano : Coffee
    {
        public typeOfRoast TypeOfRoast { get; set; }

        public Americano(int caffeine = 0, bool hasMilk = false, bool hasSugar = false, typeOfRoast typeOfRoast = typeOfRoast.Medium)
    : base(caffeine, hasMilk, hasSugar)
        {
            TypeOfRoast = typeOfRoast;
            Name = "Americano";
            Price = 1.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\americano.jpg";
            Description = "Caffè Americano is a type of coffee drink prepared by diluting an espresso with hot water, giving it a similar strength to, but different flavor from, traditionally brewed coffee.The strength of an Americano varies with the number of shots of espresso and the amount of water added.";
        }
    }
}