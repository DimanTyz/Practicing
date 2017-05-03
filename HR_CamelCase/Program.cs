using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int count;
            if (s[0] < 97)
                count = 0;
            else
                count = 1;


            foreach (char item in s)
            {

                if ((int)item<97)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
