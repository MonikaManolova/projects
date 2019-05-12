using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int times = int.Parse(Console.ReadLine());

            int diff = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers.Length-1; j > i; j--)
                {
                    if (numbers[i] - numbers[j] == times || numbers[j] - numbers[i] == times)
                    {
                        diff++;
                    }
                }
              
            }
            Console.WriteLine(diff);
        }
    }
}
