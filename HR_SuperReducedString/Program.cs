using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            bool flag = true;
            while (flag)
            {
                flag = Operation(ref s);
            }

            Console.WriteLine(string.IsNullOrEmpty(s)? "Empty String" : s);

            Console.ReadKey();
        }

        public static bool Operation(ref string s)
        {
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i+1])
                {
                    s = s.Replace(new string(s[i],2), "  ");
                    //s = s.Replace(s[i+1], ' ');
                    s = RemoveSpace(s);
                    return true;
                }
            }

            return false;
        }

        public static string RemoveSpace(string s)
        {
            string temp = "";
            foreach (var item in s)
            {
                if(item!=' ')
                temp += item;
            }
            return temp;
        }
    }
}
