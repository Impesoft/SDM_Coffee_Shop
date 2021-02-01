using SDM_Coffee_Shop.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public partial class FormMain : Form
    {
        private ShoppingCart _cart;
        private IBeverageRepo beverageRepo;
        private int iDCounter = 1;

        public FormMain()
        {
            InitializeComponent();

            beverageRepo = new BeverageRepo();
            var beverages = beverageRepo.GetBeverages();
            _cart = ShoppingCart.GetShoppingCart();
            GenerateControlsForBeverages(beverages);
        }

        private void GenerateControlsForBeverages(IEnumerable<IBeverage> beverages)
        {
            int i = 1;
            foreach (IBeverage beverage in beverages)
            {
                GridControl myUserControl = new GridControl
                {
                    Name = $"GridControl{i}",
                    GridID = beverage.ProductID,
                    MyProductName = beverage.Name,
                    Price = "€ " + beverage.Price.ToString(),
                    Image = beverage.Image
                };
                i++;
                myUserControl.AddToCartButtonClicked += AddToCartClickedInGridControl;

                flowLayoutPanel1.Controls.Add(myUserControl);
            }
        }

        private void GenerateShoppingCartList(IBeverage beverage)
        {
            int i = 1;
            //var beverages = _cart.GetBeveragesInCart();
            //beverage = beverages
            CartControl myUserControl = new CartControl
            {
                Name = $"CartControl{i}",
                //ID = _cart.GetAmountOfItemsInCart(),
                MyProductName = beverage.Name,
                Price = beverage.Price.ToString(),
                Info = beverage.ToString(),
                CurrentBeverage = beverage
            };
            myUserControl.RemoveFromCartButtonClicked += RemoveFromCartClickedInCartControl;
            i++;
            flowLayoutPanel2.Controls.Add(myUserControl);
        }

        private void btnClearCart_Click(object sender, System.EventArgs e)
        {

            _cart.ClearCart();
            flowLayoutPanel2.Controls.Clear();
            lblPrice.Text = _cart.CalculatePrice().ToString();
            SetAmountLabel();
        }
        private void AddToCartClickedInGridControl(object sender, EventArgs e)
        {
            if (_cart.GetAmountOfItemsInCart() == 10)
            {
                MessageBox.Show("Maximum number of orders reached (10).", "Maximum Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_cart.GetAmountOfItemsInCart() == 9)
                {
                    SetLabelsRed();
                }

                var userControl = sender as FormOrder;
                userControl.CurrentBeverage.UniqueID = iDCounter;

                _cart.AddBeverageToCart(userControl.CurrentBeverage);

                GenerateShoppingCartList(userControl.CurrentBeverage);
                lblPrice.Text = _cart.CalculatePrice().ToString();
                SetAmountLabel();
                iDCounter++;
            }

        }
        private void RemoveFromCartClickedInCartControl(object sender, EventArgs e)
        {
            if (_cart.GetAmountOfItemsInCart() == 10)
            {
                SetLabelsWhite();
            }

            var userControl = sender as CartControl;
            _cart.RemoveBeverageFromCart(userControl.CurrentBeverage);

            flowLayoutPanel2.Controls.Remove(userControl);
            lblPrice.Text = _cart.CalculatePrice().ToString();
            SetAmountLabel();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            FormInvoice form = new FormInvoice();
            form.ShowDialog();
        }        

        private void SetAmountLabel()
        {
            lblAmountOfItemsInCart.Text = _cart.GetAmountOfItemsInCart().ToString();
        }
        private void SetLabelsRed()
        {
            lbl1.ForeColor = Color.Red;
            lblAmountOfItemsInCart.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
        }
        private void SetLabelsWhite()
        {
            lbl1.ForeColor = Color.WhiteSmoke;
            lblAmountOfItemsInCart.ForeColor = Color.WhiteSmoke;
            label2.ForeColor = Color.WhiteSmoke;
        }
    }
}
