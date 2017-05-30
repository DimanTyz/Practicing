using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Terminated due to time out

namespace HR_GeometricTric
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    for (int k = 0; k < s.Length; k++)
                    {
                        if (s[i] == 'a' && s[j] == 'b' && s[k] == 'c'  && (Math.Pow(j+1, 2)==(i+1)*(k+1)))
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
