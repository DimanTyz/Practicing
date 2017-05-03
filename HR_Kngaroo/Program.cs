using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Kngaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(temp[0]), v1 = Convert.ToInt32(temp[1]), x2 = Convert.ToInt32(temp[2]), v2 = Convert.ToInt32(temp[3]);
            
            if(v2 < v1)
            while(x1 <= x2)
            {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2)
                    {
                        Console.WriteLine("YES");
                        return;
                    }

                    
            }

            Console.WriteLine("NO");
            Console.ReadKey();
        }
    }
}
