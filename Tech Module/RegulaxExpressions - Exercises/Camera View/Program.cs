using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int skip = input[0];
            int take = input[1];

            Regex pattern = new Regex(@"(?<=\|<)(?<text>\w+)");
            string inputLine = Console.ReadLine();

            string[] matches = pattern.Matches(inputLine)
                .Cast<Match>()
                .Select(a => a.Groups["text"].Value)
                .ToArray();

            var output = new List<string>();
            foreach (var text in matches)
            {
                if (text.Length >= skip + take)
                {
                    output.Add(text.Substring(skip, take));
                }
                else if (text.Length < skip + take)
                {
                    output.Add(text.Remove(0, skip));
                }
                else if (text.Length <= skip)
                {
                    continue;
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
