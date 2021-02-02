using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Coffee : Beverage
    {
        public typeOfCaffeine Caffeine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        protected Coffee()

        {
        }

        public override List<Control> GetControls()
        {
            List<Control> TempList = new List<Control>();
            CheckBox CHasMilk = new CheckBox();
            CHasMilk.Text = "Milk";
            CHasMilk.Name = "CHasMilk";
            CHasMilk.Checked = false;
            HasMilk = CHasMilk.Checked;
            CHasMilk.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasMilk);

            CheckBox CHasSugar = new CheckBox();
            CHasSugar.Text = "Sugar";
            CHasSugar.Name = "CHasSugar";
            CHasSugar.Checked = false;
            HasSugar = CHasSugar.Checked;
            CHasSugar.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasSugar);

            ComboBox CCaffeine = new ComboBox();

            foreach (var item in Enum.GetValues(typeof(typeOfCaffeine)))
            {
                CCaffeine.Items.Add(item + " Caffeïne");
            }
            CCaffeine.SelectedIndex = 1;
            Caffeine = (typeOfCaffeine)CCaffeine.SelectedIndex;
            CCaffeine.Name = "CCaffeine";
            CCaffeine.TextChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CCaffeine);
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

                case "CHasSugar":
                    HasSugar = ((CheckBox)x).Checked;
                    break;

                case "CCaffeine":
                    Caffeine = (typeOfCaffeine)((ComboBox)x).SelectedIndex;
                    break;
            }
        }

        public override string ToString()
        {
            return $"Caffeïne: {Caffeine},Milk:{(HasMilk ? "Yes" : "No")},Sugar: {(HasSugar ? "Yes" : "No")}";
        }
    }
}