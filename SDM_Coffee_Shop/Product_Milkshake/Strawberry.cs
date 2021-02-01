using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Strawberry : Milkshake
    {
        public bool IsFreshFruit { get; set; }

        public Strawberry()
        {
            Name = "Strawberry Shake";
            Price = 5.99;
            Image = "strawberry";
            Description = "Who can resist Strawberry Milkshake? Look at is cute pinkness! See how tender it looks? I bet it will taste as sweet as my first kiss! Now the question is, with dairy or without?";
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