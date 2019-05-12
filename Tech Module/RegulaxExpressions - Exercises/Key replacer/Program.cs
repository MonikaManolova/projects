using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = Console.ReadLine();

            string patternStart = @"^[a-zA-Z]+[<|\\]";
            string patternEnd = @"[|<\\][a-zA-Z]+$";

            var startMatch = Regex.Match(input, patternStart);
            var endMatch = Regex.Match(input, patternEnd);

            string startKey = startMatch.Value.TrimEnd('\\', '<', '|');
            string endKey = endMatch.Value.TrimStart('\\', '<', '|');

            string extractPattern = $"{startKey}(.*?){endKey}";

            StringBuilder result = new StringBuilder();

            foreach (Match word in Regex.Matches(text, extractPattern))
            {
                result.Append(word.Groups[1].Value);
            }
            Console.WriteLine(result.Length == 0 ? "Empty result" : result.ToString());
        }
    }