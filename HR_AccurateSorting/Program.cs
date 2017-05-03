using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        List<int[]> list = new List<int[]>();
        for (int a0 = 0; a0 < q; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(a_temp, Int32.Parse);
            // Write Your Code Here
            //int[] tempm = new int[arr.Length];
            //arr.CopyTo(tempm, 0);
            
            int temp = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1 - write; sort++)
                {
                    if (arr[sort] > arr[sort + 1] && (arr[sort] - arr[sort + 1] == 1))
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                };
            }
            //Array.Sort(tempm);
            string ans = "Yes";
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i+1])
                    continue;
                else
                { ans = "No"; break; }

            }
            Console.WriteLine(ans);

        }
    }
}
