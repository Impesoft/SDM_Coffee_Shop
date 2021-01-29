using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal abstract class Coffee : Beverage
    {
        public typeOfCaffeine Caffeine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        protected Coffee()

        {
        }

        public override List<Control> CreateControls()
        {
            List<Control> test = new List<Control>();
            CheckBox CHasMilk = new CheckBox();
            CHasMilk.Text = "Milk";
            CHasMilk.Name = "CHasMilk";
            CHasMilk.CheckedChanged += new System.EventHandler(this.SetControls);
            test.Add(CHasMilk);

            CheckBox CHasSugar = new CheckBox();
            CHasSugar.Text = "Sugar";
            CHasSugar.Name = "CHasSugar";
            CHasSugar.CheckedChanged += new System.EventHandler(this.SetControls);
            test.Add(CHasSugar);

            ComboBox CCaffeine = new ComboBox();

            foreach (var item in Enum.GetValues(typeof(typeOfCaffeine)))
            {
                CCaffeine.Items.Add(item + " Caffeïne");
            }
            CCaffeine.SelectedIndex = 1;
            CCaffeine.Name = "CCaffeine";
            CCaffeine.TextChanged += new System.EventHandler(this.SetControls);
            test.Add(CCaffeine);
            return test;
        }

        public virtual void SetControls(object sender, EventArgs e)
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

                case "CCaffeine":
                    Caffeine = (typeOfCaffeine)((ComboBox)x).SelectedIndex;
                    break;
            }
        }
    }
}