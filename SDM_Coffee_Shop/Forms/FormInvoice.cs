using System;
using System.Collections.Generic;

namespace SDM_Coffee_Shop
{
    public partial class FormInvoice : MetroFramework.Forms.MetroForm
    {
        private ShoppingCart shoppingCart { get; set; }

        public FormInvoice()
        {
            InitializeComponent();
            shoppingCart = ShoppingCart.GetShoppingCart();
            label1.Text = GetProducts();
            label2.Text = GetTotalPrice();
        }

        public string GetProducts()
        {
            string output = "";
            List<IBeverage> cart = shoppingCart.GetBeveragesInCart();
            foreach (IBeverage beverage in cart)
            {
                string[] properties = beverage.ToString().Split(',');

                output += $"\n\n{cart.IndexOf(beverage)}. {beverage.Name} Price: {beverage.Price} euro\n";
                foreach (string prop in properties)
                {
                    output += prop + " ";
                }
            }

            return output;
        }

        public string GetTotalPrice()
        {
            double price = ShoppingCart.GetShoppingCart().CalculatePrice();
            return $"\nTotal price : {Math.Round(price, 2)} euro \t Excl. BTW: {Math.Round(price * 0.79, 2) } \t BTW: {Math.Round(price * 0.21, 2) }";
        }
    }
}