using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n%2!=0 || (n>=6 && n<=20))
            {
                Console.WriteLine("Weird");
            }
            else
                Console.WriteLine("Not Weird");
        }
    }
}
