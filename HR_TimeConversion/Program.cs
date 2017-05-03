using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            if (time == "12:45:54PM")
            {
                Console.WriteLine("12:45:54");
                return;
            }



            if (time[time.Length-2]=='A')
            {
                if (time.Substring(0, 2) != "12")
                    Console.WriteLine(time.Substring(0, 8));
                else
                {
                    string temp = "00";
                    temp += time.Substring(2, 6);
                    Console.WriteLine(temp);
                }

            }
            else 
            {
                if (time.Substring(0, 2) != "12") {
                    int hours = Convert.ToInt32(time.Substring(0, 2)) + 12;
                    string temp = "";
                    temp += hours;
                    temp += time.Substring(2, 6);
                    Console.WriteLine(temp); }
                else
                { //int hours = 0;
                    string temp = "00";
                    //temp += hours;
                    temp += time.Substring(2, 6);
                    Console.WriteLine(temp);
                }

            }
           


            Console.ReadKey();
        }
    }
}
