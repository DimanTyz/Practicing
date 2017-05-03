using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    //static int counter;

    static void Main(String[] args)


    {
        List<int> results = new List<int>();
        int g = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < g; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] sequence_temp = Console.ReadLine().Split(' ');
            int[] sequence = Array.ConvertAll(sequence_temp, Int32.Parse);
            // If Alice wins, print 'Alice' on a new line; otherwise, print 'Bob'
            int counter = 0;
            Play(sequence, ref counter);
            results.Add(counter);
        }
        foreach (var item in results)
        {
            if (item%2==0)
            {
                Console.WriteLine("Bob");
            }
            else
                Console.WriteLine("Alice");
        }


        Console.ReadKey();
    }

    static void Play(int[] sequence,ref int counter)
    {
        for (int i = 1; i < sequence.Length - 1; i++)
        {
            if (sequence[i-1] == 0 && sequence[i+1] == 0)
            {
                sequence[i] = 1834;
                counter++;
                List<int> ltemp = new List<int>()
;                int[] temp = new int[sequence.Length - 1];
                for (int j = 0; j < sequence.Length; j++)
                {
                    if (sequence[j]!=1834)
                    {
                        ltemp.Add(sequence[j]);
                    }
                }
                temp = ltemp.ToArray();                //Array.Clear(sequence, i, 1);
                Play(temp,ref counter);
            }
        }
        //return counter;
    }
}
