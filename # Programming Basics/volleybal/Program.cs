using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleybal
{
    class Program
    {
        static void Main(string[] args)
        {
            string godina = Console.ReadLine().ToLower();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double sofiaweekend = (48 - h) * 3.0 / 4;
            double homegames = h;
            double gamespraznik = p * (2.0 / 3);
            double sum = sofiaweekend + homegames + gamespraznik;
            if (godina == "leap")
            {
                sum = sum + (sum* 0.15);

            }
            Console.WriteLine(Math.Truncate(sum));
        }
    }
}
