using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int max = -1, count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            foreach (var item in arr)
            {
                if (item == max)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
