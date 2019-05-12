using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _18.Extract_sentences_by_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var sentences = Console.ReadLine();
            var pattern = $"[^.!?;]*(({word}\\W)|(\\W{word}\\W))[^.!?;]*";

            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(sentences, pattern);

            var count = 0;
            foreach (Match match in matches)
            {
                if (count == 0)
                {
                    Console.WriteLine(match.ToString());
                }
                else
                {
                    var sentence = Convert.ToString(match);
                    Console.WriteLine(sentence.Substring(1));
                }

                count++;
            }


        }
    }
}