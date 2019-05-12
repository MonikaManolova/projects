using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string proj = Console.ReadLine().ToLower();
            double red = double.Parse(Console.ReadLine());
            double kolona = double.Parse(Console.ReadLine());
            double razmer = red * kolona;
            double price = 0;
            if (proj == "premiere") price = 12.00;
            else if (proj == "normal") price = 7.50;
            else if (proj == "discount") price = 5.00;

            Console.WriteLine("{0:f2} leva", price * razmer );



        }
    }
}
