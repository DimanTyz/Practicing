using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_IntroForSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();
            string n = Console.ReadLine();
            string[] arr = Console.ReadLine().Split(' ');


            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == v)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
