using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade_comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string grad = Console.ReadLine().ToLower();
            double sell = double.Parse(Console.ReadLine());
            double commission = -1;
            if (grad == "sofia")
            {
                if (sell >= 0 && sell <= 500) commission = 0.05;
               else if (sell > 500 && sell <= 1000) commission = 0.07;
               else if (sell > 1000 && sell <= 10000) commission = 0.08;
               else if (sell > 10000) commission = 0.12;
            }
            if (grad == "varna")
            {
                if (sell >= 0 && sell <= 500) commission = 0.045;
               else if (sell > 500 && sell <= 1000) commission = 0.075;
               else if (sell > 1000 && sell <= 10000) commission = 0.1;
               else if (sell > 10000) commission = 0.13;
            }
            if (grad == "plovdiv")
            {
                if (sell >= 0 && sell <= 500) commission = 0.055;
               else if (sell > 500 && sell <= 1000) commission = 0.08;
               else if (sell > 1000 && sell <= 10000) commission = 0.12;
               else if (sell > 10000) commission = 0.145;
            }
            if (commission > 0)
            {
                Console.WriteLine("{0:f2}", commission*sell);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
