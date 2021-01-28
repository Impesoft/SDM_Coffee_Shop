using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop.Product_Milkshake
{
    internal class Strawberry : Milkshake
    {
        public bool IsFrozenFruit { get; set; }

        public Strawberry(bool hasDairy, bool hasWhippedCream, bool isFrozenFruit)
            : base(hasDairy, hasWhippedCream)
        {
            IsFrozenFruit = isFrozenFruit;
            Name = "Strawberry Shake";
            Price = 5.99;
            Image = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "IMG\\strawberry.jpg";
            Description = "Who can resist Strawberry Milkshake? Look at is cute pinkness! See how tender it looks? I bet it will taste as sweet as my first kiss! Now the question is, with dairy or without?";
        }
    }
}