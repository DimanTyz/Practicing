using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int max = arr[0], min = arr[0];
            int maxcount = 0, mincount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    maxcount++;
                    max = arr[i];
                }
                else if (arr[i] < min)
                {  mincount++;
                min = arr[i];
            }
            }

            Console.WriteLine(maxcount + " " + mincount);
        }
    }
}
