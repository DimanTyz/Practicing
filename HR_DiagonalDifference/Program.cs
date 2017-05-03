using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            string[] temp = new string[n];
            int diag1 = 0; int diag2 = 0;
            for (int i = 0; i < n; i++)
            {
                temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToInt32(temp[j]);

                    if (i==j)
                    {
                        diag1 += arr[i, j];
                    }

                    if ( j + i == n - 1)
                    {
                        diag2 += arr[i, j];
                    }
                }                           
            }

            Console.WriteLine(Math.Abs(diag1 - diag2));




            Console.ReadKey();
        }
    }
}
