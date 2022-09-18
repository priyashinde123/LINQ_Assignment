using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace LINQ.Assignment1
{
    internal class linq2
    {
        public static void Execute()
        {

            Console.WriteLine("Enter Year");
            int year = Custom.isIntegerOrNot();
            Console.WriteLine("Enter Month");
            int month = Custom.isIntegerOrNot();
            Console.WriteLine("No of Days in Month As Below");
            Console.WriteLine(System.DateTime.DaysInMonth(year, month));
            Console.WriteLine("No of Days in Year ");

            if ((year % 4 == 0 || year % 400 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("366");
            }
            else
            {
                Console.WriteLine("365");
            }
            Console.ReadLine();
        }
    }
}

