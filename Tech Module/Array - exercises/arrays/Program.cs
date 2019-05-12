using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main()
        {
            string[] stringOne = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] stringTwo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int maxCountLeft = maxCountNumbers(stringOne, stringTwo);
                 Array.Reverse(stringOne);
                 Array.Reverse(stringTwo);
            
            int maxCountRight = maxCountNumbers(stringOne, stringTwo);
            Console.WriteLine($"{Math.Max(maxCountLeft, maxCountRight)}");
            
        }

        private static int maxCountNumbers(string[] stringOne, string[] stringTwo)
        { 
                 int lenght = Math.Min(stringOne.Length, stringTwo.Length);
                 int count = 0;

            for (int i = 0; i < lenght; i++)
            {
                if (stringOne[i] == stringTwo[i])
                {
                    count++;
                }

                else
                {
                    break;
                }
            }
                return count;

        }
    }
}

