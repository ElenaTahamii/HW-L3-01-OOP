using System;
using System.Collections.Generic;
using System.Text;

namespace management__online_shop
{
    class Clothing : Product
    {
        public string Size;
        public string Material;
        public override void GetProductDetails()
        {
            Console.WriteLine("Information Product");
            Console.WriteLine($" Name :{Name}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Size : {Size}");
            Console.WriteLine($"Material {Material}");
            Console.WriteLine("---------------------------------------");

        }

    }
}