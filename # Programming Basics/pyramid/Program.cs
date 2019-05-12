using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пирамида
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int chislo = 1;
            int red = 1;

            while (n >= chislo)
            {
                for (int j = 1; j <= red; j++)
                {
                    Console.Write(chislo + " ");
                    chislo++;

                    if (chislo > n)
                        break;
                }              
                Console.WriteLine();
                red++;
            }
        }
    }
}
