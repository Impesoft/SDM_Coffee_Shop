using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Espresso : Coffee
    {
        public typeOfRoast TypeOfRoast { get; set; }

        public Espresso()
        {
            Name = "Espresso";
            Price = 2.99;
            Image = "espresso";
            Description = "Espresso is a coffee-brewing method of Italian origin, in which a small amount of nearly boiling water is forced under 9–10 bars of atmospheric pressure through finely-ground coffee beans. Espresso coffee can be made with a wide variety of coffee beans and roast degrees.";
        }

        public override List<Control> CreateControls()
        {
            ComboBox CTypeOfRoast = new ComboBox();
            foreach (var item in Enum.GetValues(typeof(typeOfRoast)))
            {
                CTypeOfRoast.Items.Add(item + " Roast");
            }

            CTypeOfRoast.SelectedIndex = 1;
            List<Control> test2 = base.CreateControls();
            CTypeOfRoast.Name = "CTypeOfRoast";
            CTypeOfRoast.TextChanged += new System.EventHandler(this.SetControls);
            test2.Add(CTypeOfRoast);
            return test2;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            base.SetControls(sender, e);
            if ((sender as Control).Name == "CTypeOfRoast")
            {
                var x = sender as ComboBox;

                TypeOfRoast = (typeOfRoast)((ComboBox)x).SelectedIndex;
            }
        }
    }
}