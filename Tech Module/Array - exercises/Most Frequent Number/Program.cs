using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int replicant = 0;
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;


                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        
                    }
                    
                }

                if (counter > replicant)
                {
                    replicant = counter;
                    result = numbers[i];
                }
               
            }

            Console.WriteLine(result);
        }
    }
}
