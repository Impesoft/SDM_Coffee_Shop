using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Coffee_Shop
{
    public partial class FormInvoice : MetroFramework.Forms.MetroForm
    {
        public FormInvoice()
        {
            InitializeComponent();

            label1.Text = GetProducts();
            label2.Text = GetTotalPrice();
        }

        public string GetProducts()
        {
            string output = "";
            foreach (var item in ShoppingCart.GetShoppingCart().GetBeveragesInCart())
            {
                output += $"{item.UniqueID}. {item.Name} Price: {item.Price} euro\n{item.ToString()}\n\n ";
            }

            return output;
        }

        public string GetTotalPrice()
        {
            double price = 0;
            foreach (var item in ShoppingCart.GetShoppingCart().GetBeveragesInCart())
            {
                price += item.Price;
            }

            return $"\nTotal price : {price} euro \t Excl. BTW: {price * 0.79} \t BTW: {price * 0.21}";
        }
    }
}