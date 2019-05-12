using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Къщичка
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zvezda = 1;

            if (n % 2 == 0)
             zvezda = 2;

                for (int i = 0; i < (n+1)/2; i++)
                {
                   
                    Console.WriteLine("{0}{1}{0}", new string ('-', (n - zvezda) / 2), new string('*',zvezda));
                    zvezda += 2;
                }
                for (int i = 0; i < n/2; i++)
                {
                    Console.WriteLine("|{0}|",new string('*',n-2));
                }
            
        }
    }
}
