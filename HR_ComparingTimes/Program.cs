using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_ComparingTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> answers = new List<string>();
            int n = int.Parse(Console.ReadLine());
            string[] times;

            for (int i = 0; i < n; i++)
            {
                times = Console.ReadLine().Split(' ');

                if (times[0][5]!=times[1][5])
                {
                    if (times[0][5] == 'A')
                        answers.Add("First");
                    else
                        answers.Add("Second");

                    continue;
                }

                int[] hours = new int[2];
                int[] minutes = new int[2];

                for (int j = 0; j < 2; j++)
                {
                    hours[j] = Convert.ToInt32(times[j].Substring(0, 2));
                    minutes[j] = Convert.ToInt32(times[j].Substring(3, 2));
                }

                if (hours[0] == 12 && hours[1]!=12)
                {
                    answers.Add("First");
                    continue;
                }

                if (hours[1] == 12 && hours[0]!=12)
                {
                    answers.Add("Second");
                    continue;
                }


                if (hours[0]> hours[1])
                {
                    answers.Add("Second");
                    continue;
                }
                else if(hours[1] > hours[0])
                {
                    answers.Add("First");
                    continue;
                }
                else if (minutes[0]>minutes[1])
                {
                    answers.Add("Second");
                    continue;
                }
                else if (minutes[0]<minutes[1])
                {
                    answers.Add("First");
                    continue;
                }

                answers.Add("First");



            }


            foreach (var item in answers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
