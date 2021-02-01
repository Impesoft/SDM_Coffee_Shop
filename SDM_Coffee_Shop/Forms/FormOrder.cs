using System;
using System.Drawing;
using System.Resources;

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

        public event EventHandler OrderButtonClicked;

        protected virtual void OnOrderButtonClicked(EventArgs e)
        {
            OrderButtonClicked?.Invoke(this, e);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OnOrderButtonClicked(e);
            Close();
        }
    }
}