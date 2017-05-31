using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] temparr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                temparr[i] = arr[arr.Length - 1 - i];
            }

            for (int i = 0; i < temparr.Length; i++)
            {
                Console.Write(temparr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
