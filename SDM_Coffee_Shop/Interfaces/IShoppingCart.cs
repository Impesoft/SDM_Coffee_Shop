using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    public interface IShoppingCart
    {
        void AddBeverageToCart(IBeverage beverage); 
    }
}
