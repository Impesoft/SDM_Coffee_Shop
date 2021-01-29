using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop.UserControls
{
    public partial class CartControl : UserControl
    {
        public CartControl()
        {
            InitializeComponent();
        }

        public int ID { get; set; }
        public string MyProductName
        {
            get { return lblNameProduct.Text; }
            set { lblNameProduct.Text = value; }
        }
        public string Price
        {
            get { return lblPriceProduct.Text; }
            set { lblPriceProduct.Text = value; }
        }

        public event EventHandler RemoveFromCartButtonClicked;
        protected virtual void OnRemoveFromCartButtonClicked(EventArgs e)
        {
            RemoveFromCartButtonClicked?.Invoke(this, e);
        }
        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            OnRemoveFromCartButtonClicked(e);
        }
    }
}
