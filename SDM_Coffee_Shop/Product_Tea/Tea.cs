using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal abstract class Tea : Beverage
    {
        public typeOfTheine Theine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        public Tea()
        {
        }

        public override List<Control> GetControls()
        {
            List<Control> TempList = new List<Control>();
            CheckBox CHasMilk = new CheckBox();
            CHasMilk.Text = "Milk";
            CHasMilk.Name = "CHasMilk";
            CHasMilk.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasMilk);

            CheckBox CHasSugar = new CheckBox();
            CHasSugar.Text = "Sugar";
            CHasSugar.Name = "CHasSugar";
            CHasSugar.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasSugar);

            ComboBox CTheine = new ComboBox();
            foreach (var item in Enum.GetValues(typeof(typeOfCaffeine)))
            {
                CTheine.Items.Add(item + " Theine");
            }
            CTheine.SelectedIndex = 1;
            CTheine.Name = "CTheine";
            CTheine.TextChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CTheine);

            return TempList;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            var x = sender as Control;
            switch (x.Name)
            {
                case "CHasMilk":
                    HasMilk = ((CheckBox)x).Checked;
                    break;

                case "CSugar":
                    HasSugar = ((CheckBox)x).Checked;
                    break;

                case "CTheine":
                    Theine = (typeOfTheine)((ComboBox)x).SelectedIndex;
                    break;
            }
        }
    }
}