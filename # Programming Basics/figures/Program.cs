using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figura
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = 0;
            double y1 = 0;

            double x2 = h * 3;
            double y2 = h;

            double x3 = h;
            double y3 = h;

            double x4 = h*2;
            double y4 = h*4;

            var tochkax = x > x1 && x < x2 && y > y1 && y < y2;
            var tochkay = x > x3 && x < x4 && y > y3 && y < y4;
            
            var lejix1 = x == x1 && (y >= y1 && y <= y2) || x == x2 && (y >= y1 && y <= y2);
            var lejix2 = x == x3 && (y >= y3 && y <= y4) || x == x4 && (y >= y3 && y <= y4);
           
            var lejiy1 = y == y1 && (x >= x1 && x <= x2) || y == y2 && (x >= x1 && x <= x2);
            var lejiy2 = y == y3 && (x >= x3 && x <= x4) || y == y4 && (x >= x3 && x <= x4);

            bool vutre = y == y2 && x3 < x && (x3 * 2) > x;
            if (tochkax || vutre || tochkay)
            {
                Console.WriteLine("inside");
            }
            else if (lejix1 || lejix2 || lejiy1 || lejiy2)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}
