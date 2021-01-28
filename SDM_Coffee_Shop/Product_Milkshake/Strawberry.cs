using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal class Strawberry : Milkshake
    {
        public bool IsFrozenFruit { get; set; }

        public Strawberry()
        {
            
            Name = "Strawberry Shake";
            Price = 5.99;
            Image = "strawberry";
            Description = "Who can resist Strawberry Milkshake? Look at is cute pinkness! See how tender it looks? I bet it will taste as sweet as my first kiss! Now the question is, with dairy or without?";
        }
    }
}