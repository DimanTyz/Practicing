using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int[] Solve(int[] a, int[] b)
    {
        // Complete this function
        int[] temp = { 0, 0 };
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > b[i])
                temp[0]++;
            else if (b[i] > a[i])
                temp[1]++;
        }
        return temp;
    }

    static void Main(String[] args)
    {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        int[] a = { a0, a1, a2 };
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] b = { b0, b1, b2 };
        int[] result = Solve(a, b);

        //Convert.toul

        //Console.WriteLine(String.Join(" ", result));
        Console.WriteLine(result[0] + " " + result[1]);

        Console.Read();


    }
}
