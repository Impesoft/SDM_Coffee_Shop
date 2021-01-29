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

namespace SDM_Coffee_Shop.UserControls
{
    public partial class GridControl : UserControl
    {        
        private ShoppingCart _cart;
        private IBeverageRepo _repo;

        public GridControl()
        {
            InitializeComponent();

            _cart = ShoppingCart.GetShoppingCart();
            _repo = new BeverageRepo();            
        }   
        public int ID { get; set; }

        public string MyProductName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string Image
        {
            set
            {
                if (value != null)
                {
                    ResourceManager rm = Properties.Resources.ResourceManager;
                    Bitmap myImage = (Bitmap)rm.GetObject(value);

                    btnInfo.BackgroundImage = myImage;
                }
            }
        }

        //ADD EVENT HANDLER
        private void btnInfosmall_Click(object sender, EventArgs e)
        {
            IBeverage beverage = _repo.GetBeverage(ID);
            Form form = new FormAbout(beverage);
            form.Show();
        }


        //ADD EVENT HANDLER
        public event EventHandler AddToCartButtonClicked;
        protected virtual void OnAddToCartButtonClicked(EventArgs e)
        {
            AddToCartButtonClicked?.Invoke(this, e);
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            OnAddToCartButtonClicked(e);         
            
        }        
    }
}