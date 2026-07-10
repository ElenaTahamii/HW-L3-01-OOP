using System;
using System.Collections.Generic;
using System.Text;

namespace management__online_shop
{
    class Electronic:Product,IDiscountable
    {
        public int WarrantyPeriod;   
        public override void GetProductDetails()
        {
            Console.WriteLine(" Information Product ");
            Console.WriteLine($" Name : {Name} ");
            Console.WriteLine($" Warranty Period : {WarrantyPeriod}");
            Console.WriteLine($"Orginal Price : {Price}");
            Console.WriteLine ($"DiscountedPrice :{FinalPrice} ");
            Console.WriteLine("---------------------------------------");



        }

        public void ApplyDiscount()

        {
            double discountPercent=20;
            double discountAmount;
            discountAmount = (Price * discountPercent) / 100;
            FinalPrice = Price - discountAmount;
        }
            
    }
}
