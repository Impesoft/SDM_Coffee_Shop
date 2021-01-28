using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal class Cappuccino : Coffee
    {
        public Cappuccino(int caffeine = 0, bool hasMilk = false, bool hasSugar = false)
           : base(caffeine, hasMilk, hasSugar)
        {
            Name = "Cappuccino";
            Price = 4.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\cappuccino.jpg";
            Description = "A cappuccino is an espresso-based coffee drink that originated in Italy, and is traditionally prepared with steamed milk foam. Variations of the drink involve the use of cream instead of milk, using non-dairy milks, and flavoring with cinnamon or chocolate powder.";
        }
    }
}