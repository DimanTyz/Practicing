using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fline = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int charged = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != fline[1])
                    sum += arr[i];
            }
            int actual = sum / 2;

            Console.WriteLine(actual==charged ? "Bon Appetit" : (charged-actual).ToString());


            Console.ReadKey();

        }
    }
}
