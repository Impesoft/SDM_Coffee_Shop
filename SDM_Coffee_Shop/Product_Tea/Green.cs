using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop.Product_Tea
{
    internal class Green : Tea
    {
        public Green(int theine, bool hasMilk, bool hasSugar)
           : base(theine, hasMilk, hasSugar)
        {
            Name = "Green Tea";
            Price = 2.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\green.jpg";
            Description = "Green tea is a type of tea that is made from Camellia sinensis leaves and buds that have not undergone the same withering and oxidation process used to make oolong teas and black teas. Green tea originated in China, but its production and manufacture has spread to other countries in East Asia.";
        }
    }
}