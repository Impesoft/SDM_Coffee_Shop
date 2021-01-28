using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    internal class BeverageRepo : IBeverageRepo
    {
        public IBeverage GetBeverage(int id)
        {
            List<IBeverage> allBeverages = GetBeverages();

            // LAMBDA Expression. Return the first object in which the ID property equals user input
            var selectedBeverage = allBeverages.Where(x => x.ID == id).FirstOrDefault();

            return selectedBeverage;
        }

        public List<IBeverage> GetBeverages()
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
    }
}