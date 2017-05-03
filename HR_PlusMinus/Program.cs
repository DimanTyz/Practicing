using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int zcount = 0, pcount = 0, mcount = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    pcount++;
                }
                else if (arr[i] < 0)
                {
                    mcount++;
                }
                else
                    zcount++;
            }

            Console.WriteLine((double)pcount/n);
            Console.WriteLine((double)mcount/n);
            Console.WriteLine((double)zcount/n);

            Console.ReadKey();
        }
    }
}
