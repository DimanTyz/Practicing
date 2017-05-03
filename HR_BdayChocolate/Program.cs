using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_BdayChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] dm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int d = dm[0], m = dm[1];
            int count = 0, tempsum = 0;

            int[] temparr = new int[m];


            for (int i = 0; i < arr.Length; i++)
            {
                if (i + temparr.Length < arr.Length + 1)
                {
                    for (int j = 0; j < temparr.Length; j++)
                    {
                        temparr[j] = arr[i + j];
                    }
                    tempsum = 0;
                    for (int k = 0; k < temparr.Length; k++)
                    {
                        tempsum += temparr[k];
                    }
                    if (tempsum == d)
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
