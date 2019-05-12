using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace фибоначи
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int f0 = 1;
            int f1 = 1;
            int fn = 1;

            if (n == 1 || n == 0) Console.WriteLine(fn);
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                }
                Console.WriteLine(fn);
            }
        }
    }
}
