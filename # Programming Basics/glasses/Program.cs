using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
            for (int i = 0; i < n-2; i++)
            {
                if (i == (n-1)/ 2 - 1)
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string('|', n));

                else
                    Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));

        }
    }
}
