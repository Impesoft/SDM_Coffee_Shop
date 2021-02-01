using System.Collections.Generic;

namespace SDM_Coffee_Shop
{
    public interface IBeverageRepo
    {
        List<IBeverage> GetBeverages();

        IBeverage GetBeverage(int id);
    }
}