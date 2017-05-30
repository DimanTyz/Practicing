using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Duplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "01101001";

            int n = int.Parse(Console.ReadLine());
            List<int> queries = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                queries.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int max = -1;

            for (int i = 0; i < queries.Count; i++)
            {
                if (queries[i] > max)
                {
                    max = queries[i];
                }
            }


            while (s.Length < max)
            {
                string t = ReverseS(s);
                s = s + t;
            }


            foreach (var item in queries)
            {
                Console.WriteLine(s[item]);
            }

            //Console.WriteLine(ReverseS(s));

            Console.ReadKey();
        }

        static string ReverseS(string s)
        {
            string temp = "";
            foreach (char c in s)
            {
                if (c == '1')
                {
                    temp += '0';
                }
                else
                    temp += '1';
            }
            return temp;
        }
    }
}
