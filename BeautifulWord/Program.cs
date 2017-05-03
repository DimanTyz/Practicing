using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BeautifulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "Yes";
            string w = Console.ReadLine();
            char[] letters = w.ToCharArray();
            char[] constraints = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < letters.Length-1; i++)
            {
                if (letters[i] == letters[i+1])
                {
                    ans = "No";
                }

                for (int j = 0; j < constraints.Length; j++)
                {
                    if (letters[i] == constraints[j])
                    {
                        for (int k = 0; k < constraints.Length; k++)
                        {
                            if (letters[i+1]==constraints[k] )
                            {
                                ans = "No";
                            }
                        }
                    }
                }
            }


            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
