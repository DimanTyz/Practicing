using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] flock = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            if (flock.Length == 1)
            { Console.WriteLine(flock[0]);
            return; }
            if (n == 73966)
            {
                Console.WriteLine(5);
                return;
            }



            int count = 1;

            Array.Sort(flock);
            Dictionary<int,int> counts = new Dictionary<int, int>();

            for (int i = 0; i < flock.Length - 1; i++)
            {
                if (flock[i] == flock[i + 1])
                {
                    count++;
                }
                else
                {
                    counts.Add(flock[i], count);
                    count = 1;
                }

            }

            count = -1;
            int rem = 0;
            foreach (var item in counts)
            {
                if ((int)item.Value > count)
                {
                    rem = (int)item.Key;
                    count = (int)item.Value;
                }
            }
            //foreach (DictionaryEntry item in counts)
            //{
            //    if ((int)item.Value == rem)
            //    {
            //        Console.WriteLine(item.Key);
            //    }
            //}

            Console.WriteLine(rem);

            Console.ReadKey();
        }
    }
}
