using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long sum = 1;
            for (long i = 1; i <= n; i++)
            {
                sum = sum * i;
            }
            
            Console.WriteLine(sum);
        }
    }
}
