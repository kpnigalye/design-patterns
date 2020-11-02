using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_pattern
{
    // Client Code
    // Code to calculate billing amount
    class Program
    {
        static void Main(string[] args)
        {
            AmountFinalizer calc = new AmountFinalizer();

            Console.WriteLine($"Final bill amount for the purchase of Rs. 450 is {calc.GetBillingAmount(450)}");

            Console.WriteLine($"Final bill amount for the purchase of Rs. 1200 is {calc.GetBillingAmount(1200)}");

            Console.WriteLine($"Final bill amount for the purchase of Rs. 2500 is {calc.GetBillingAmount(2500)}");

            Console.ReadLine();
        }
    }
}
