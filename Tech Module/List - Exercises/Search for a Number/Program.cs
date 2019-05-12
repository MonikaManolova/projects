using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] manipulator = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> resultList = numbers.Take(manipulator[0]).ToList();
            resultList.RemoveRange(0, manipulator[1]);
            if (resultList.Contains(manipulator[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            

            // second example 60 % only

            /*
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] manipulator = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();          

            numbers.RemoveRange(manipulator[0] + 1, (numbers.Count - 1) - manipulator[0]);
            numbers.RemoveRange(0, manipulator[1]);

            if (numbers.Contains(manipulator[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            */
        }
    }
}
