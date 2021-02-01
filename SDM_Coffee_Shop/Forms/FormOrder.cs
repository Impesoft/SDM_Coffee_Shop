using System;
using System.Drawing;
using System.Resources;

namespace SDM_Coffee_Shop
{
    public partial class FormOrder : MetroFramework.Forms.MetroForm
    {
        public IBeverage CurrentBeverage { get; set; }

        public FormOrder(IBeverage beverage)
        {
            CurrentBeverage = beverage;
            InitializeComponent();
            Text = CurrentBeverage.Name;

            ResourceManager rm = Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(CurrentBeverage.Image);
            metroLabel1.Text = CurrentBeverage.Description;

            int i = 65;

            foreach (var control in CurrentBeverage.GetControls())
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

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OnOrderButtonClicked(e);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}