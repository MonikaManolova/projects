using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int equals = 1;
            int tempequals = 1;
            int result = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempequals++;

                    if (tempequals > equals)
                    {
                        equals = tempequals;
                        result = arr[i];
                    }
                }

                else
                {
                    tempequals = 1;
                }
                if (equals == 1)
                {
                    result = arr[0];
                }

            }
            for (int i = 0; i < equals; i++)
            {
                Console.Write(result + " ");
            }
        }
    }
}
