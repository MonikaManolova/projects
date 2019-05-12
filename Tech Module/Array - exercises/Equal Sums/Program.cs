using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries )
                .Select(int.Parse)
                .ToArray();

            bool equalSum = false;

            for (int i = 0; i < array.Length; i++)
            {
                int[] leftArr = array.Take(i).ToArray();
                int[] rightArr = array.Skip(i+1).ToArray();
                if (leftArr.Sum() == rightArr.Sum())
                {
                    Console.WriteLine(i);
                    equalSum = true;
                    break;
                }             
            }

            if (!equalSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
