using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        
      /* Read a list of integers and find the longest increasing subsequence. 
      * If several such exist, print the leftmost.*/


        public class LargestIncreasingSubsequence
        {
            public static void Main()
            {
                var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var longestSeq = FindLongestIncreasingSubsequence(sequence);
                Console.WriteLine(string.Join(" ", longestSeq));
            }

            public static int[] FindLongestIncreasingSubsequence(int[] sequence)
            {
                int maxLength = 0;
                int lastIndex = -1;
                int[] length = new int[sequence.Length];
                int[] prev = new int[sequence.Length];

                for (int index = 0; index < sequence.Length; index++)
                {
                    length[index] = 1;
                    prev[index] = -1;

                    for (int i = 0; i < index; i++)
                    {
                        if (sequence[i] < sequence[index] && length[i] + 1 > length[index])
                        {
                            length[index] = length[i] + 1;
                            prev[index] = i;
                        }
                    }

                    if (length[index] > maxLength)
                    {
                        maxLength = length[index];
                        lastIndex = index;
                    }
                }

                var longestMatrix = new int[maxLength];
                int currentIndex = maxLength - 1;

                while (lastIndex != -1)
                {
                    longestMatrix[currentIndex] = sequence[lastIndex];
                    currentIndex--;
                    lastIndex = prev[lastIndex];
                }

                return longestMatrix.ToArray();
            }
        }
    }
}

