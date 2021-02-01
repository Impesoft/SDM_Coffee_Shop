using System.Collections.Generic;
using System.Linq;

namespace SDM_Coffee_Shop
{
    internal class BeverageRepo : IBeverageRepo
    {
        private static List<IBeverage> _listOfProducts = null;

        public IBeverage GetBeverage(int id)
        {
            List<IBeverage> allBeverages = GetBeverages();

            // LAMBDA Expression. Return the first object in which the ID property equals user input
            var selectedBeverage = allBeverages.Where(x => x.ProductID == id).FirstOrDefault();

            return selectedBeverage;
        }

        public List<IBeverage> GenerateBeverages()
        {
            var beverages = new List<IBeverage>
            {
                new Cappuccino(),
                new Americano(),
                new Deca(),
                new Espresso(),
                new Black(),
                new Green(),
                new Iced(),
                new Mint(),
                new Banana(),
                new Chocolate(),
                new Strawberry(),
                new Vanilla(),
                new WhiteRussian(),
                new PinaColada(),
                new WhiskeySour(),
            };

            return beverages;
        }

        public List<IBeverage> GetBeverages()
        {
            if (_listOfProducts == null)
            {
                _listOfProducts = GenerateBeverages();
            }

            return _listOfProducts;
        }
    }
}