using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace LINQ.Assignment
{
    internal class Q7
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
            Console.WriteLine("enter enter the range of price that is from price to price");
            
            int price1 = Custom.isIntegerOrNot();
            int price2 = Custom.isIntegerOrNot();
            
            foreach (Product product in list)
            {
                if(price1<product.price && price2>product.price)
                    Console.WriteLine(product.name + " " + product.brand + " " + product.price);
            }
           
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
