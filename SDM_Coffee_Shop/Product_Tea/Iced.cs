using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal class Iced : Tea
    {
        public int AmountOfCubes { get; set; } \\TODO

        public Iced()
        {
            Name = "Iced Tea";
            Price = 4.99;
            Image = "iced";
            Description = "Iced tea is a form of cold tea. Though usually served in a glass with ice, it can refer to any tea that has been chilled or cooled. It may be sweetened with sugar, syrup and/or apple slices.";
        }
    }
}