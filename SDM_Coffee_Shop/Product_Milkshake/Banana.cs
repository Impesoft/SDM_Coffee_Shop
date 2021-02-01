using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Banana : Milkshake
    {
        public bool IsFreshFruit { get; set; }

        public Banana()
        {
            Name = "Banana Shake";
            Price = 5.99;
            Image = "banana";
            Description = "With a few ingredients, a banana milkshake is easy to make and is super satisfying. It can be made in minutes. What's not to like?! Now the question is, with dairy or without?";
        }

        public override List<Control> GetControls()
        {
            List<Control> TempList = new List<Control>();
            CheckBox CIsFreshFruit = new CheckBox();
            CIsFreshFruit.Text = "Not frozen Fruit";
            CIsFreshFruit.Name = "CIsFreshFruit";
            CIsFreshFruit.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CIsFreshFruit);

            List<Control> test2 = base.GetControls();
            test2.Add(CIsFreshFruit);
            return test2;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            base.SetControls(sender, e);
            if ((sender as Control).Name == "CIsFreshFruit")
            {
                IsFreshFruit = ((CheckBox)sender).Checked;
            }
        }
    }
}