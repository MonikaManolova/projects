using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            string command = Console.ReadLine();

            while (command != "print")
            {
                var commandInstructions = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

                if (commandInstructions[0] == "add")
                {

                    numbers.Insert(int.Parse(commandInstructions[1]), int.Parse(commandInstructions[2]));
                }

                else if (commandInstructions[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(commandInstructions[1]), commandInstructions.Skip(2).Select(int.Parse).ToArray());
                }

                else if (commandInstructions[0] == "contains")
                {
                    int indexNumber = int.Parse(commandInstructions[1]);
                    if (numbers.Contains(indexNumber))
                    {
                        Console.WriteLine(numbers.IndexOf(indexNumber));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }

                else if (commandInstructions[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(commandInstructions[1]));
                }

                else if (commandInstructions[0] == "shift")
                {
                    int number = int.Parse(commandInstructions[1]);
                    number = number % numbers.Count;
                    for (int i = 0; i < number; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                    
                }

                else if (commandInstructions[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count -1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }
    }
}
