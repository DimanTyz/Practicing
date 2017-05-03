using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());


            if (year > 1918)
            {
                Console.WriteLine(IsLeapedForGreg(year)?"12.09.{0}":"13.09.{0}", year );
            }
            else if (year < 1918)
            {
                Console.WriteLine(IsLeapedForJul(year)?"12.09.{0}":"13.09.{0}",year);
            }
            else
            {
                Console.WriteLine("26.09.1918");
            }





            Console.ReadKey();
        }

        static bool IsLeapedForGreg(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        static bool IsLeapedForJul(int year)
        {
            return year % 4 == 0;
        }
    }
}
