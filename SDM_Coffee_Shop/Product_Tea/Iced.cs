using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    internal class Iced : Tea
    {
        public int AmountOfCubes { get; set; } //TODO

        public Iced()
        {
            Name = "Iced Tea";
            Price = 4.99;
            Image = "iced";
            Description = "Iced tea is a form of cold tea. Though usually served in a glass with ice, it can refer to any tea that has been chilled or cooled. It may be sweetened with sugar, syrup and/or apple slices.";
        }

        public override List<Control> GetControls()
        {
            List<Control> TempList = base.GetControls();
            NumericUpDown CAmountOfCubes = new NumericUpDown();
            CAmountOfCubes.Text = "Amount of Cubes";
            CAmountOfCubes.Name = "CAmountOfCubes";
            CAmountOfCubes.Value = 3;
            CAmountOfCubes.Minimum = 0;
            CAmountOfCubes.Maximum = 5;

            CAmountOfCubes.DecimalPlaces = 0;
            CAmountOfCubes.ValueChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CAmountOfCubes);

            return TempList;
        }

        public override void SetControls(object sender, EventArgs e)
        {
            base.SetControls(sender, e);
            if ((sender as Control).Name == "CAmountOfCubes")
            {
                AmountOfCubes = (int)((NumericUpDown)sender).Value;
            }
        }
    }
}