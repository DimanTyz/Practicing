using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0], k = nk[1];
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if ((numbers[i] + numbers[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
