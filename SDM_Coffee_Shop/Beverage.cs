using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public class Beverage : IBeverage
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description { get; set; }

        private static int PID = 1;
        public int UniqueID { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }
        public int ProductID { get; set; }

        public Beverage()
        {
            ProductID = PID;
            PID++;
        }

        public override string ToString()
        {
            string result = $"{Price.ToString()}, {Description}, {ProductID}, {Image}, {Name}";
            return result;
        }

        public virtual List<Control> GetControls()
        {
            return null;
        }

        public virtual void SetControls(object sender, EventArgs e)
        {
        }

        public void ResetUniqueId()
        {
            UniqueID = 1;
        }
    }
}