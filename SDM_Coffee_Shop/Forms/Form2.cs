using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public partial class FormAbout : Form
    {
        public FormAbout(IBeverage beverage)
        {
            InitializeComponent();
            Text = "More info about a " + beverage.Name;
            lblAboutDescription.Text = beverage.Description;
            ResourceManager rm = Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(beverage.Image);

            pictureBox1.Image = myImage;

            // pictureBox1.Image = Directory.GetParent(Properties.Resources.deca).FullName + "IMG\\deca.jpg";
            //Image = ;

            //pictureBox1.
        }

        private void btnAboutBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}