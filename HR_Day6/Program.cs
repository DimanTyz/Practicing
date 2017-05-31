using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            string temp1 = "", temp2 = "";
            foreach (string item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        temp1 += item[i];
                    }
                    else
                        temp2 += item[i];
                }
                Console.WriteLine(temp1 + " " + temp2);
                temp1 = ""; temp2 = "";
            }

            Console.ReadKey();

        }
    }
}
