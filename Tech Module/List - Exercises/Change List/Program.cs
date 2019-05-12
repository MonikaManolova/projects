using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "Odd" && command != "Even")
            {

                var manipulator = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (manipulator[0] == "Delete")
                {

                            int index = int.Parse(manipulator[1]);
                            numbers.RemoveAll(x => x == index );
                }

                else if (manipulator[0] == "Insert")
                {
                    numbers.Insert(int.Parse(manipulator[2]), int.Parse(manipulator[1]));
                }
                command = Console.ReadLine();

            }

            if (command == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
        }
    }
}
