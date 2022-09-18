using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Assignment1
{
    internal class linq1
    {
        public static void Execute()
        {
            Console.WriteLine("Enetr No of fruits");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Details");

            List<string> fruits = new List<string>();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter Details");
                fruits.Add(Console.ReadLine());
            }

            var result = (from c in fruits
                          orderby c ascending
                          select c).ToList();
            Console.WriteLine("List Of Fruits in Assscending Order");
            foreach (var abc in result)
            {
                Console.WriteLine(abc);
            }
            Console.ReadLine();

        }
            
    }
}
