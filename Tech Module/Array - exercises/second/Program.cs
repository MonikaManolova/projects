using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
              int[] numbers = Console.ReadLine()
                  .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

              int k = numbers.Length / 4;

              int[] leftArr = numbers.Take(k).ToArray();
              int[] middArr = numbers.Skip(k).Take(k * 2).ToArray();
              int[] rightArr = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

              int[] result = new int[k * 2];

              for (int i = 0; i < k; i++)
              {
                  result[i] = leftArr[i] + middArr[i];
                  result[i + k] = rightArr[i] + middArr[i + k];
              }
              
            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }
}
