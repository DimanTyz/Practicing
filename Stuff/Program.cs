using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double e = double.Parse(Console.ReadLine());
            int i = 1;

            while (true)
            {
                x += (1 / Math.Pow(2, i));
                i++;

                if (x < e) break;
            }


            Console.WriteLine(x);

            Console.ReadKey();

        }
    }
}
