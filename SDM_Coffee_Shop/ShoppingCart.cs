using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    class ShoppingCart : IShoppingCart
    {
        private List<IBeverage> _beverages;

        private static ShoppingCart _cart;

        public ShoppingCart()
        {
            _beverages = new List<IBeverage>();
        }

        public static ShoppingCart GetShoppingCart()
        {
            if (_cart == null)
            {
                _cart = new ShoppingCart();
            }

            return _cart;
        }

        public void AddBeverageToCart(IBeverage beverage)
        {
            _beverages.Add(beverage);
        }
    }
}
