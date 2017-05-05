using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_FunnyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            int n = int.Parse(Console.ReadLine());
            string[] answers = new string[n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string reverse ="";
                for (int j = s.Length - 1; j >= 0; j--)
                {
                    reverse += s[j];
                }

                for (int j = 0; j < s.Length - 1; j++)
                {
                   
                    if (Math.Abs(alphabet.IndexOf(reverse[j+1]) - alphabet.IndexOf(reverse[j])) != Math.Abs(alphabet.IndexOf(s[j+1]) -alphabet.IndexOf(s[j])))
                    {
                        answers[i] = "Not Funny";
                        break;
                    }
                }
                if (answers[i] == null)
                {
                    answers[i] = "Funny";
                }
                //Console.WriteLine(reverse);

            }
            foreach (var item in answers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
