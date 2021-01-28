using SDM_Coffee_Shop.UserControls;
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
            foreach (IBeverage beverage in beverages)
            {
                UserControl1 myUserControl = new UserControl1
                {
                    ID = beverage.ID,

                    MyProductName = beverage.Name,
                    Price = beverage.Price.ToString(),

                    Image = beverage.Image
                };                

                flowLayoutPanel1.Controls.Add(myUserControl);
            }
        }

        //TEST
        public void UpdateShoppingCartInfo(IBeverage beverage)
        {

            lblPrice.Text = beverage.Name;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            lblPrice.Text = _cart.CalculatePrice().ToString();
        }

        private void btnClearCart_Click(object sender, System.EventArgs e)
        {
            _cart.ClearCart();
        }
    }
}