using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_FindTheBug
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];

            int I = 0, J = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == 'X')
                    {
                        I = i;
                        J = j;
                    }
                }

            }

            Console.WriteLine(I + "," + J);

            Console.ReadKey();
        }
    }
}
