using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] primes = new bool[n+1];
         
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (primes[i]!= true)
                {
                    for (int j = i*i; j < primes.Length; j+=i)
                    {
                        primes[j] = true;
                    }

                }
            }
            for (int i = 2; i < primes.Length; i++)
            {
                if (!primes[i])
                {
                    Console.Write("{0} ",i);
                }
            }
        }
    }
}
