using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter even number: ");
                var n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) Console.WriteLine("Even number entered: {}");
                    break;

                Console.WriteLine("The number is not even.");
            }
                
        }
    }
}
