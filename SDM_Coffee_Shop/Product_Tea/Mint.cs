using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Mint : Tea
    {
        public typeOfTea TypeOfTea { get; set; }

        public Mint()
        {
            Name = "Mint Tea";
            Price = 2.99;
            Image = "mint";
            Description = "Mint tea is a herbal tea made by infusing mint leaves in hot water. Mint tea made with peppermint leaves is called peppermint tea, and mint tea made with spearmint is called spearmint tea.";
        }

        public override List<Control> GetControls()
        {
            ComboBox CTypeOfTea = new ComboBox();
            foreach (var item in Enum.GetValues(typeof(typeOfTea)))
            {
                CTypeOfTea.Items.Add(item + " Roast");
            }

            CTypeOfTea.SelectedIndex = 1;
            List<Control> test2 = base.GetControls();
            CTypeOfTea.Name = "CTypeOfTea";
            CTypeOfTea.TextChanged += new System.EventHandler(this.SetControls);
            test2.Add(CTypeOfTea);
            return test2;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            base.SetControls(sender, e);
            if ((sender as Control).Name == "CTypeOfTea")
            {
                var x = sender as ComboBox;

                TypeOfTea = (typeOfTea)((ComboBox)x).SelectedIndex;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $",Type of tea: {TypeOfTea}";
        }
    }
}