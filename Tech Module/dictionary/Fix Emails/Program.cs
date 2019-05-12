using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailsDict = new Dictionary<string, string>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                string domain = email.Substring(email.Length - 2);

                if (domain == "uk" || domain == "us")
                {
                    continue;
                }
                else
                {
                    emailsDict.Add(input, email);
                }
            }
            foreach (var email in emailsDict)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");

            }
        }
    }
}
