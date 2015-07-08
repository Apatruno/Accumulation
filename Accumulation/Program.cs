using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accumulation Lab2 part1
            double deposit = 35.00;
         
            int year = 365;
            //Here is where each year is being Multiplied by 35 to show the account amount after 1,2,5,and 10 years of deposits.
            double y1 = year * deposit;
            double y2 = year * 2 * deposit;
            double y5 = year * 5 * deposit;
            double y10 = year * 10 * deposit;

            //.ToString("C2") will add the $ (C for currency) and .00 (2 for two decimal places).
            Console.WriteLine("The women has " + y1.ToString("C2") + " after 1 year of deposits.");
            Console.WriteLine("The women has " + y2.ToString("C2") + " after 2 years of deposits.");
            Console.WriteLine("The women has " + y5.ToString("C2") + " after 5 years of deposits.");
            Console.WriteLine("The women has " + y10.ToString("C2") + " after 10 years of deposits.");

            Console.Read();
        }
    }
}
