using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace чертане_на_фигури_с_цикли
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0;j < i ; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
