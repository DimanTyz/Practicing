using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string sos = "SOS";
            int count = 0;
            for(int i = 0; i< s.Length; i++)
            {
                if (s[i] != sos[i % 3])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
