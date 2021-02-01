﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public abstract class Cocktail : Beverage
    {
        public bool HasIce { get; set; }

        public int PercentageAlcohol { get; set; }

        protected Cocktail()
        {
            PercentageAlcohol = 50;
        }

        public override List<Control> GetControls()
        {
            List<Control> TempList = new List<Control>();
            CheckBox CHasIce = new CheckBox();
            CHasIce.Text = "With Ice";
            CHasIce.Name = "CHasIce";
            CHasIce.CheckedChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CHasIce);

            Label LBLPercentageAlcohol = new Label();
            LBLPercentageAlcohol.Text = "Select your alcohol percentage: ";
            LBLPercentageAlcohol.Width = 200;

            TempList.Add(LBLPercentageAlcohol);
            TrackBar CPercentageAlcohol = new TrackBar();
            CPercentageAlcohol.Name = "CPercentageAlcohol";
            CPercentageAlcohol.Width = 200;
            CPercentageAlcohol.BackColor = System.Drawing.Color.White;
            CPercentageAlcohol.ValueChanged += new System.EventHandler(this.SetControls);
            TempList.Add(CPercentageAlcohol);

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

                case "CPercentageAlcohol":
                    PercentageAlcohol = ((TrackBar)x).Value;
                    break;
            }
        }
    }
}