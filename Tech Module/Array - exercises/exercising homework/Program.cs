using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercising_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            int count = 0;
           int frequentNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int temporaryCount = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i]==numbers[j])
                    {
                        temporaryCount++;
                    }                  
                }

                if (temporaryCount > count)
                {
                    count = temporaryCount;
                    frequentNumber =numbers[i];

                }               
            }

            Console.WriteLine(frequentNumber);
        }
    }
}
