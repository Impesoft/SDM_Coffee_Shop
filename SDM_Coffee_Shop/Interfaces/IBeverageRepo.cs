﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM_Coffee_Shop
{
    public interface IBeverageRepo
    {
        List<IBeverage> GetBeverages();

        IBeverage GetBeverage(int id);
    }
}
