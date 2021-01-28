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
        public int AmountOfCubes { get; set; }

        public Iced(int theine = 0, bool hasMilk = false, bool hasSugar = false, int amountOfCubes = 0)
           : base(theine, hasMilk, hasSugar)
        {
            AmountOfCubes = amountOfCubes;
            Name = "Iced Tea";
            Price = 4.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\iced.jpg";
            Description = "Iced tea is a form of cold tea. Though usually served in a glass with ice, it can refer to any tea that has been chilled or cooled. It may be sweetened with sugar, syrup and/or apple slices.";
        }
    }
}