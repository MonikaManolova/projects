using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine("{0}{1} | {1}{0}", new string(' ', n - i), new string('*', i)); 
            }
        }
    }
}
