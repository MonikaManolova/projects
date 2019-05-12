using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

             if (n % 2 == 0 )
             {
                int leftright = (n - 1) / 2;
                int mid = 0;

                for (int i = 0; i <= n / 2 - 1 ; i++)
                 {
                    if (i == 0)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', leftright), "**");
                    }
                    else
                    {
                        mid += 2;
                        leftright--;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', leftright), new string('-', mid));
                    }
                 }
                 for (int i = 0; i < (n - 1) / 2; i++)
                 {
                    if (i == n - 1) Console.WriteLine("{0}**{0}", new string('-', leftright));
                    else
                    {
                        mid -= 2;
                        leftright++;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', leftright), new string('-', mid));
                    }
                 }
             }

             else if (n % 2 != 0)
             {
               int mid = 1;
                int leftright = n / 2;
                 for (int i = 0; i < n / 2 +1; i++)
                 {
                    if (i == 0) Console.WriteLine("{0}*{0}", new string('-', leftright));

                    else 
                    {
                        leftright--;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', leftright), new string('-', mid));
                        mid += 2;
                    }
                }
                mid -= 2;
               for (int i = 0; i <n / 2; i++)
                {
                   if (i == n/2 -1) Console.WriteLine("{0}*{0}", new string('-', n/2));

                   else
                   {
                        mid -= 2;
                        leftright++;
                        Console.WriteLine("{0}*{1}*{0}", new string('-', leftright), new string('-', mid));
                      
                    }
                }               
            }

        }
    }
}

