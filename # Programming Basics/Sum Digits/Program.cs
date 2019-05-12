using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int chislo = n;

            while (chislo > 0)
            {
                int lastchislo = chislo % 10;
                chislo = chislo / 10;
                sum += lastchislo;
            }
            Console.WriteLine(sum);
        }
    }
}
