using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

                var product = Console.ReadLine().ToLower();
                var grad = Console.ReadLine().ToLower();
                double quantity = double.Parse(Console.ReadLine());

                if (grad == "sofia")
                {

                    if (product == "coffee") Console.WriteLine(quantity * 0.50);
                    else if (product == "water") Console.WriteLine(quantity * 0.80);
                    else if (product == "beer") Console.WriteLine(quantity * 1.20);
                else if (product == "sweets") Console.WriteLine(quantity * 1.45);
                    else if (product == "peanuts") Console.WriteLine(quantity * 1.60);
                }
                if (grad == "plovdiv")
                {
                    if (product == "coffee") Console.WriteLine(quantity * 0.40);
                    else if (product == "beer") Console.WriteLine(quantity * 1.15);
                    else if (product == "water") Console.WriteLine(quantity * 0.70);
                else if (product == "sweets") Console.WriteLine(quantity * 1.30);
                    else if (product == "peanuts") Console.WriteLine(quantity * 1.50);
                }
                if (grad == "varna")
                {
                    if (product == "coffee") Console.WriteLine(quantity * 0.45);
                    else if (product == "beer") Console.WriteLine(quantity * 1.10);
                    else if (product == "water") Console.WriteLine(quantity * 0.70);
                else if (product == "sweets") Console.WriteLine(quantity * 1.35);
                    else if (product == "peanuts") Console.WriteLine(quantity * 1.55);
                }
            }
        }
    }

    

