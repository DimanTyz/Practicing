using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] st = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] counts = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int [] avalues = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int [] bvalues = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int acount = 0, bcount = 0;
            for (int i = 0; i < avalues.Length; i++)
            {
                if (ab[0] + avalues[i] >= st[0] && ab[0] + avalues[i] <= st[1])
                {
                    acount++;
                }
            }
            for (int i = 0; i < bvalues.Length; i++)
            {
                if (ab[1] + bvalues[i] >= st[0] && ab[1] + bvalues[i] <= st[1])
                {
                    bcount++;
                }
            }
            Console.WriteLine(acount);
            Console.WriteLine(bcount);

            Console.ReadKey();
        }
    }
}
