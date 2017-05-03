using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] grades = new int[n];
            for (int i = 0; i < n; i++)
            {
                grades[i] = int.Parse(Console.ReadLine());
            }



            for (var i = 0; i < n; i++)
            {
                //if (grades[i] > 37)
                //    if (grades[i] % 5 == 3)
                //        grades[i] += 2;
                //    else if (grades[i] % 5 == 4)
                //        grades[i] += 1;

                //Console.WriteLine(grades[i]);

                Console.WriteLine(grades[i] < 38 || grades[i] % 5 < 3 ? grades[i] : grades[i] + (5 - grades[i] % 5));
            }

            Console.ReadKey();
        }
    }
}
