using SDM_Coffee_Shop.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public partial class Form1 : Form
    {
        private ShoppingCart _cart;
        private IBeverageRepo beverageRepo;

        public Form1()
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
                    ID = beverage.ID,
                    MyProductName = beverage.Name,
                    Price = beverage.Price.ToString(),
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

            CartControl myUserControl = new CartControl
            {
                Name = $"CartControl{i}",
                ID = beverage.ID,
                MyProductName = beverage.Name,
                Price = beverage.Price.ToString()
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
        }

        private void AddToCartClickedInGridControl(object sender, EventArgs e)
        {
            var userControl = sender as GridControl;

            var beverage = beverageRepo.GetBeverage(userControl.ID);
            _cart.AddBeverageToCart(beverage);

            GenerateShoppingCartList(beverage);
            lblPrice.Text = _cart.CalculatePrice().ToString();
        }

        private void RemoveFromCartClickedInCartControl(object sender, EventArgs e)
        {
            var userControl = sender as CartControl;
            _cart.RemoveBeverageFromCart(_cart.GetBeverageInCart(userControl.ID));

            flowLayoutPanel2.Controls.Remove(userControl);
            lblPrice.Text = _cart.CalculatePrice().ToString();
        }
    }
}