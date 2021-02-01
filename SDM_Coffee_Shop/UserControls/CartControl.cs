using System;
using System.Windows.Forms;

namespace SDM_Coffee_Shop.UserControls
{
    public partial class CartControl : UserControl
    {
       
        public CartControl()
        {
            InitializeComponent();
        }

        public int CartID
        {
            get { return Convert.ToInt32(lblid.Text); }
            set { lblid.Text = value.ToString(); ; }
        }

        public IBeverage CurrentBeverage { get; set; }

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

        public string Info
        {
            get;
            set;
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

        private void btnProductInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Info, "Product Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}