using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.ToUpper();
            string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNM";
            List<char> list = new List<char>(alphabet);

            foreach (char c in s)
            {
                if (list.Contains(c))
                {
                    list.Remove(c);
                }
            }

            Console.WriteLine(list.Count==0 ? "pangram" : "not pangram");

            Console.ReadKey();
        }
    }
}
