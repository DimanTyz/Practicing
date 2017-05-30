using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_FightTheMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nht = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] monsters = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int h = nht[1];
            int t = nht[2];

            int min = int.MaxValue;
            int index = -1;
            int count = 0;

            for (int j = 0; j < t; j++)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i] > 0 && monsters[i] < min)
                    {
                        min = monsters[i];
                        index = i;
                    }
                }

                monsters[index] -= h;
                min = int.MaxValue;

                if (monsters[index] <= 0)
                    count++;
            }

            Console.WriteLine(count);

            Console.ReadKey();
            

        }
    }
}
