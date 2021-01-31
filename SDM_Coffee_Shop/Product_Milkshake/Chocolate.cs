using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Chocolate : Milkshake
    {
        public typeOfChocolate TypeOfChocolate { get; set; }

        public Chocolate()
        {
            Name = "Chocolate Shake";
            Price = 5.99;
            Image = "chocolate";
            Description = "Three simple ingredients are all it takes to make an easy homemade chocolate milkshake. Vanilla ice cream, ice cold milk, HERSHEY'S Syrup. Blend, pour, sip.";
        }

        public override List<Control> CreateControls()
        {
            ComboBox CTypeOfChocolate = new ComboBox();
            foreach (var item in Enum.GetValues(typeof(typeOfChocolate)))
            {
                CTypeOfChocolate.Items.Add(item + " Chocolate");
            }

            CTypeOfChocolate.SelectedIndex = 1;
            List<Control> test2 = base.CreateControls();
            CTypeOfChocolate.Name = "CTypeOfChocolate";
            CTypeOfChocolate.TextChanged += new System.EventHandler(this.SetControls);
            test2.Add(CTypeOfChocolate);
            return test2;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            base.SetControls(sender, e);
            if ((sender as Control).Name == "CTypeOfChocolate")
            {
                var x = sender as ComboBox;

                TypeOfChocolate = (typeOfChocolate)((ComboBox)x).SelectedIndex;
            }
        }
    }
}