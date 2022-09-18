using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;


namespace LINQ.Assignment
{
    internal class Q5
    {
        public static void execute()
        {
            List<Product> list = new List<Product>();
            while (true)
            {
                Console.WriteLine("want to add product yes/ no");
                if (Console.ReadLine() == "yes")
                    addproduct(list);
                else
                    break;
            }
            Console.WriteLine("enter two brand from list");
            string brand1=Console.ReadLine();
            string brand2=Console.ReadLine();
            int price1 = 0;
            int price2 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Product product = list[i];
                if (brand1 == product.brand)
                {
                   price1 = product.price;
                }
                if (brand2 == product.brand)
                {
                    price2 = product.price;
                }
            }
            if(price1 > price2)
                Console.WriteLine($"price of {brand1} is greater than {brand2}");
            else
                Console.WriteLine($"price of {brand2} is greater than {brand1}");
        }
        public static void addproduct(List<Product> list)
        {

            Console.WriteLine("enter the name,brand,price");
            String name = Console.ReadLine();
            String brand = Console.ReadLine();
           int price = Custom.isIntegerOrNot();
            list.Add(new Product(name, brand, price));
        }

    }
}
