using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionarty
{
    class Program
    {
        static void Main()
        {

            
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            bool continueSearch = true;

            while (continueSearch)
            {
                string[] commandArr = Console.ReadLine()
                    .Split();

                foreach (var name in commandArr)
                {
                    if (commandArr[0] == "A")
                    {
                        if (phonebook.ContainsKey(commandArr[1]))
                        {
                            phonebook[commandArr[1]] = commandArr[2];
                        }
                        else
                        {
                            phonebook.Add(commandArr[1], commandArr[2]);
                        }
                    }

                    else  
                    {
                        if (phonebook.ContainsKey(commandArr[1]))
                        {
                            Console.WriteLine($"{commandArr[1]} -> {phonebook[commandArr[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {commandArr[1]} does not exist.");
                        }
                    }

                    
                }

                if (commandArr[0] == "END")
                {
                    continueSearch = false;
                }
            }
        }
    }
}

