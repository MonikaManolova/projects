using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = "(\\s[a-zA-Z0-9][\\w.-]*\\@[a-z-A-Z-]+)(\\.[a-zA-Z]+)+";

            Regex regX = new Regex(pattern);

            MatchCollection findMatch = regX.Matches(input);

            foreach (Match email in findMatch)
            {
                Console.WriteLine(email);
            }
        }
    }
}