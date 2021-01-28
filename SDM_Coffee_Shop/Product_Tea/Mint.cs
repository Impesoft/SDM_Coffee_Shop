using System;
using System.IO;

namespace SDM_Coffee_Shop
{
    internal class Mint : Tea
    {
        public enum typeOfTea
        {
            peppermint = 1,
            spearmint = 2,
        };

        public typeOfTea TypeOfTea { get; set; }

        public Mint()
        {
            Name = "Mint Tea";
            Price = 2.99;
            Image = "mint";
            Description = "Mint tea is a herbal tea made by infusing mint leaves in hot water. Mint tea made with peppermint leaves is called peppermint tea, and mint tea made with spearmint is called spearmint tea.";
        }
    }
}