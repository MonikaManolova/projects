using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = -1;

            if (day == "monday"||day== "tuesday"|| day == "wednesday" || day== "thursday" || day == "friday")
            {
                if (fruit == "banana") price = 2.5;
                if (fruit == "apple") price = 1.2;
                if (fruit == "orange") price = 0.85;
                if (fruit == "grapefruit") price = 1.45;
                if (fruit == "kiwi") price = 2.7;
                if (fruit == "pineapple") price = 5.5;
                if (fruit == "grapes") price = 3.85;
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") price = 2.7;
                if (fruit == "apple") price = 1.25;
                if (fruit == "orange") price = 0.90;
                if (fruit == "grapefruit") price = 1.6;
                if (fruit == "kiwi") price = 3;
                if (fruit == "pineapple") price = 5.6;
                if (fruit == "grapes") price = 4.2;
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
