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

            int increasing = 1;
            int temp = 1;
            int start = 0;
            int resultstart = 0;

            for (int i = 1; i < arr.Length ; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    temp++;

                    if (temp > increasing)
                    {
                        increasing = temp;
                        resultstart = start;
                    }
                }

                else
                {
                    start = i;
                    temp = 1;
                }


            }
            for (int i = resultstart; i < resultstart + increasing; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
