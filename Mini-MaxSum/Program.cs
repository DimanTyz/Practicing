using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong[] arr =Array.ConvertAll(Console.ReadLine().Split(' '), UInt64.Parse);
            //ulong min = ulong.MaxValue;
            //ulong max = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i]< min)
            //    {
            //        min = arr[i];
            //    }
            //}
            ulong maxsum = 0, minsum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]!= min)
            //    {
            //        maxsum += arr[i];
            //    }
            //    if (arr[i]!=max)
            //    {
            //        minsum += arr[i];
            //    }
            //}
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minsum += arr[i];
                maxsum += arr[i + 1];
            }


            Console.WriteLine(minsum + " " + maxsum);



            //Console.ReadKey();
        }
    }
}
