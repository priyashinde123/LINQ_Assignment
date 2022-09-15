using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Assignment
{
    internal class Q2
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

            
            var myquery = (from obj in list
                            where obj.price<1000
                            select obj).ToList();



            foreach (var item in myquery)
            {
                Console.WriteLine($"name {item.name} and price {item.price}");
               
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
