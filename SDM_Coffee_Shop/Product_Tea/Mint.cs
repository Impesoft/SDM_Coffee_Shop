using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop.Product_Tea
{
    internal class Mint : Tea
    {
        public enum typeOfTea
        {
            peppermint = 1,
            spearmint = 2,
        };

        public typeOfTea TypeOfTea { get; set; }

        public Mint(int theine, bool hasMilk, bool hasSugar, typeOfTea typeOfTea)
          : base(theine, hasMilk, hasSugar)
        {
            TypeOfTea = typeOfTea;
            Name = "Mint Tea";
            Price = 2.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\mint.jpg";
            Description = "Mint tea is a herbal tea made by infusing mint leaves in hot water. Mint tea made with peppermint leaves is called peppermint tea, and mint tea made with spearmint is called spearmint tea.";
        }
    }
}