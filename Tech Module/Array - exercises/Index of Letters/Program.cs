using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            char[] arr = new char[26];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(97 + i);
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]+ " -> "+ Array.IndexOf(arr,words[i]));
            }
        }
    }
}
