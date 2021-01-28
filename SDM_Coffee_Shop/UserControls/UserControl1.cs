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
    public partial class UserControl1 : UserControl
    {
        //TODO

        //private ShoppingCart _cart;
        private IBeverageRepo _repo;

        public UserControl1()
        {
            InitializeComponent();

            //TODO
            //_cart = ShoppingCart.GetShoppingCart();
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

        

        

        private string _image;

        public string Image
        {
            set
            {
                if (value != null)
                {
                    _image = value;
                    //btnInfo.BackgroundImage = _image;
                    //pictureBox1.Load(_image);
                }
            }
        }

        //public void btnCart_Click(object sender, System.EventArgs e)
        //{
        //    var pizza = _repo.GetPizza(PizzaID);
        //    _cart.AddProductToCart(pizza);
        //}
    }
}
