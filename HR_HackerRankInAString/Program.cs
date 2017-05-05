using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_HackerRankInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            string[] temp = new string[q];
            for (int i = 0; i < q; i++)
            {
                string s = Console.ReadLine();

                temp[i] = HasHackerRankInText(s);
            }
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i] + " ");
            }

            Console.ReadKey();


        }
        private static string HasHackerRankInText(string text)
        {
            var hackerrank = new Queue<char>("hackerrank".ToCharArray());
            foreach (char c in text)
            {
                if (c == hackerrank.Peek())
                    hackerrank.Dequeue();

                if (hackerrank.Count == 0)
                    return "YES";
            }

            return "NO";
        }
    }
}
