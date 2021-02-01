using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public interface IBeverage
    {
        double Price { get; set; }

        string Description { get; set; }

        int UniqueID { get; set; }

        int ProductID { get; set; }

        string Image { get; set; }

        string Name { get; set; }

        string ToString();

        List<Control> GetControls();

        void SetControls(object sender, EventArgs e);
    }
}