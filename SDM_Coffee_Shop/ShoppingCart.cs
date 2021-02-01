using System.Collections.Generic;

namespace SDM_Coffee_Shop
{
    internal class ShoppingCart : IShoppingCart
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

        public double CalculatePrice()
        {
            double totalPrice = 0;
            foreach (var beverage in _beverages)
            {
                totalPrice += beverage.Price;
            }

            return totalPrice;
        }

        public void AddBeverageToCart(IBeverage beverage)
        {
            _beverages.Add(beverage);            
        }

        public List<IBeverage> GetBeveragesInCart()
        {
            return _beverages;
        }

        public IBeverage GetBeverageInCart(int id)
        {
            foreach (var drink in _beverages)
            {
                if (drink.UniqueID == id)
                {
                    return drink;
                }
            }
            return null;
        }
        public int GetAmountOfItemsInCart()
        {
            return _beverages.Count;
        }

        public void RemoveBeverageFromCart(IBeverage beverage)
        {
            _beverages.Remove(beverage);
        }

        public void ClearCart()
        {
            _beverages.Clear();
        }
    }
}