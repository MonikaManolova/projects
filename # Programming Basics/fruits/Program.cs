using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruits
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (a == "banana" || a == "apple" || a == "kiwi" || a == "cherry" || a == "lemon" || a == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (a == "tomato" || a == "cucumber" || a == "pepper" || a == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
