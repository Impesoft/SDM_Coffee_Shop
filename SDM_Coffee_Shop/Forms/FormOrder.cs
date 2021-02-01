using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public partial class FormOrder : MetroFramework.Forms.MetroForm
    {
        public FormOrder(IBeverage beverage)
        {
            InitializeComponent();
            Text = beverage.Name;

            ResourceManager rm = Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(beverage.Image);
            metroLabel1.Text = beverage.Description;

            int i = 65;

            foreach (var control in beverage.GetControls())
            {
                control.Location = new Point(30, i);

                Controls.Add(control);

                i += 25;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}