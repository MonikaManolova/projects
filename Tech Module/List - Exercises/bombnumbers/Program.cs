using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bombnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombnumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); 

            int bomb = bombnumbers[0];
            int bombPow = bombnumbers[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {

                    int leftSide = Math.Max(i - bombPow, 0);
                    int rightSide = Math.Min(i + bombPow, numbers.Count - 1);


                    numbers.RemoveRange(i, rightSide - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftSide, i - leftSide);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join("", numbers.Sum()));
        }
    }
}
