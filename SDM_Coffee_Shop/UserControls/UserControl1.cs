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
    public partial class UserControl1 : UserControl
    {
        private ShoppingCart _cart;
        private IBeverageRepo _repo;

        public UserControl1()
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

        private void btnInfosmall_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.Show();
            //form.imgAb
        }

      
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var beverage = _repo.GetBeverage(ID);
            _cart.AddBeverageToCart(beverage);
        }        
    }
}