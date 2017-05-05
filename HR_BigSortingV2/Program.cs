using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_BIGSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            Array.Sort(arr, new BigString());

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();

        }

    class BigString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length > y.Length)
                return 1;
            else if (x.Length < y.Length)
                return -1;
            else
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] > y[i])
                        return 1;
                    else if (x[i] < y[i])
                        return -1;
                }
            return 0;
        }
    }
}
