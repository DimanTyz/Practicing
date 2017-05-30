using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Day2
{
    interface IMy
    {

    }
    abstract class MyCLass
    {

    }
    struct Mystr: MyCLass
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            //double cost = double.Parse(Console.ReadLine());
            //double tip = double.Parse(Console.ReadLine());
            //double tax = double.Parse(Console.ReadLine());

            //Console.WriteLine("The total meal cost is {0} dollars.", Round((cost + (cost * tip / 100 + cost * tax / 100))));

           


            Console.ReadKey();

        }

        public static int Round(double sum)
        {
            if (sum % 1 >= 0.5)
            {
                return (int)sum + 1;
            }
            else
                return (int)sum;
        }
    }

}
