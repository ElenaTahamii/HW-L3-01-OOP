using System;
using System.Collections.Generic;
using System.Text;

namespace management__online_shop
{
    abstract class Product
    {
        public string Name;
        public double Price;
        public double FinalPrice;
        public abstract void GetProductDetails();

    

    }
}
