using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;


namespace LINQ.Assignment
{
    internal class Q4
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

                //q1
                // var myquery1 = (from obj in list
                //                select obj.price).Min()
                //                ;
                // var data = list.Select(x=> new { x.price,x.name }).Min(x => x.price)
                ;
            Product highestValue = (from obj in list
                                 orderby obj.price descending
                                 select obj).FirstOrDefault();
            Console.WriteLine(highestValue.name + " " + highestValue.price);


        }
        public static void addproduct(List<Product> list)
        {
            Console.WriteLine("want to add product");
            Console.WriteLine("enter the name,brand,price");
            String name = Console.ReadLine();
            String brand = Console.ReadLine();
             int price = Custom.isIntegerOrNot();
            
            list.Add(new Product(name, brand, price));
        }

    }
}
