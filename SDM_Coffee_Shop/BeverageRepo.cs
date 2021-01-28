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
            throw new NotImplementedException();
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