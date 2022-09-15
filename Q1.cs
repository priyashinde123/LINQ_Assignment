using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Assignment
{
    internal class Q1
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
            var myquery1= (from obj in list
                         where  obj.name.Contains('k')
                         select obj.name).ToList();



            foreach (var o in myquery1)
            {
                Console.WriteLine(o);
            }



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
