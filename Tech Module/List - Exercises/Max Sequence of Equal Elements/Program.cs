using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSequence
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        
        int maxNumbers = 0;
        int count = 1;
        int maxcount = 1;
        int token = 0;
        while (token < numbers.Count - 1)
        {

            if (numbers[token] == numbers[token + 1])
            {
                count++;

                if (count > maxcount)
                {
                    maxcount = count;
                    maxNumbers = numbers[token];
                }

            }
            else
            {
                count = 1;
            }
            token++;
            if (maxcount == 1)
            {
                maxNumbers = numbers[0];
            }
        }
        for (int i = 0; i < maxcount; i++)
        {
            Console.Write(maxNumbers);
            Console.Write(" ");

        }
    }
}