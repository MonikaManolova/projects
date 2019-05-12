using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArrayOne = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] charArrayTwo = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(char.Parse)
              .ToArray();

            int lenghtOfArr = Math.Min(charArrayOne.Length, charArrayTwo.Length);

            bool equals = true;

            if (charArrayOne.Length == charArrayTwo.Length)
            {

                for (int i = 0; i < lenghtOfArr; i++)
                {
                    if (charArrayOne[i] < charArrayTwo[i])
                    {
                        Console.WriteLine(string.Join("", charArrayOne));
                        Console.WriteLine(string.Join("", charArrayTwo));
                        equals = false;
                        break;
                    }
                    else if (charArrayOne[i] > charArrayTwo[i])
                    {
                        Console.WriteLine(string.Join("", charArrayTwo));
                        Console.WriteLine(string.Join("", charArrayOne));
                        equals = false;

                        break;
                    }

                }

            }
            if (charArrayOne.Length < charArrayTwo.Length)
            {
                equals = false;

                Console.WriteLine(string.Join("", charArrayOne));
                Console.WriteLine(string.Join("", charArrayTwo));
            }
            else if (charArrayOne.Length > charArrayTwo.Length)
            {
                equals = false;

                Console.WriteLine(string.Join("", charArrayTwo));
                Console.WriteLine(string.Join("", charArrayOne));
            }
            else if (equals)
            {
                Console.WriteLine(string.Join("", charArrayOne));
                Console.WriteLine(string.Join("", charArrayTwo));
            }
        }
    }
}
