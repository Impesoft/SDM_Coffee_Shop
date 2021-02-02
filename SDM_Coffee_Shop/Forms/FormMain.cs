using SDM_Coffee_Shop.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public partial class FormMain : Form
    {
        private FileReaderWriter readerWriter;
        private ShoppingCart _cart;
        private IBeverageRepo beverageRepo;
        private static int iDCounter = 1;

        public FormMain()
        {
            InitializeComponent();

            readerWriter = new FileReaderWriter();
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

            CartControl myUserControl = new CartControl
            {
                Name = $"CartControl{i}",
                CartID = beverage.UniqueID,
                MyProductName = beverage.Name,
                Price = beverage.Price.ToString(),
                Info = beverage.ToString().Replace(',', '\n'),
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
            iDCounter = 1;
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
                    SetLabelsColor(Color.Red);
                }
                if (_cart.GetAmountOfItemsInCart() == 8)
                {
                    SetLabelsColor(Color.Orange);
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
                SetLabelsColor(Color.Orange);
            }
            if (_cart.GetAmountOfItemsInCart() == 9)
            {
                SetLabelsColor(Color.White);
            }

            var userControl = sender as CartControl;
            _cart.RemoveBeverageFromCart(userControl.CurrentBeverage);

            flowLayoutPanel2.Controls.Remove(userControl);
            lblPrice.Text = _cart.CalculatePrice().ToString();
            SetAmountLabel();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            WriteToLog();
            FormInvoice form = new FormInvoice();
            form.ShowDialog();
        }

        private void WriteToLog()
        {
            List<string> result = new List<string>();
            result.Add($"Amount of products = {_cart.GetAmountOfItemsInCart()} | ");
            result.Add($"Total price = {_cart.CalculatePrice()} | ");
            foreach (var beverage in _cart.GetBeveragesInCart())
            {
                result.Add($"{beverage.Name}, {beverage.Price}, {beverage.ToString()} | ");
            }
            readerWriter.WriteDataToFile(result.ToArray());
        }

        private void SetAmountLabel()
        {
            lblAmountOfItemsInCart.Text = _cart.GetAmountOfItemsInCart().ToString();
        }

        private void SetLabelsColor(Color color)
        {
            lbl1.ForeColor = color;
            lblAmountOfItemsInCart.ForeColor = color;
            label2.ForeColor = color;
        }

        //TOREMOVE private void SetLabelsWhite()
        //{
        //  lbl1.ForeColor = Color.WhiteSmoke;
        //lblAmountOfItemsInCart.ForeColor = Color.WhiteSmoke;
        // label2.ForeColor = Color.WhiteSmoke;
        //}
    }
}