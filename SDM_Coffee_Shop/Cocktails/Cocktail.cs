using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Cocktail : Beverage
    {
        public bool HasIce { get; set; }

        public int PercentageAlcohol { get; set; }

        protected Cocktail()
        {
            PercentageAlcohol = 50;
        }

        public override List<Control> CreateControls()
        {
            List<Control> TempList = new List<Control>();
            CheckBox CHasIce = new CheckBox();
            CHasIce.Text = "Ice";
            CHasIce.Name = "CHasIce";
            CHasIce.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasIce);

            //ToAdd= PercentageAlcohol

            return TempList;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            var x = sender as Control;
            switch (x.Name)
            {
                case "CHasIce":
                    HasIce = ((CheckBox)x).Checked;
                    break;

                case "CPercentageAlcohol": //TOADD

                    break;
            }
        }
    }
}