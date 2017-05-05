using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_WeightedUniformStrings
{
   //эта хуйня не работала и я посомтрел в интернете решение. психовал. забил. нашел ошибку. в алфавите нет буквы i. все работает.
        //    static void Main(string[] args)
        //    {
        //        string s = Console.ReadLine();
        //        int n = int.Parse(Console.ReadLine());
        //        int[] queries = new int[n];
        //        for (int i = 0; i < n; i++)
        //        {
        //            queries[i] = int.Parse(Console.ReadLine());
        //        }
        //        string alphabet = " abcdefghjklmnopqrstuvwxyz";

        //        List<string> subs = new List<string>();

        //        string temp = s.Substring(0,1);
        //        for (int i = 1; i < s.Length; i++)
        //        {
        //            if (s[i] == temp[0])
        //            {
        //                temp += s[i];
        //            }
        //            else
        //            {
        //                subs.Add(temp);
        //                temp = s.Substring(i,1);
        //            }
        //        }
        //        subs.Add(temp);

        //        string[] answers = new string[queries.Length];
        //        for (int i = 0; i < answers.Length; i++)
        //        {
        //            answers[i] = "No";
        //        }



        //        for (int i = 0; i < queries.Length; i++)
        //            {
        //            foreach (var item in subs)
        //            {
        //                if (queries[i] % alphabet.IndexOf(item[0]) == 0 && (queries[i] / alphabet.IndexOf(item[0]) <= item.Length))
        //                {
        //                    answers[i] = "Yes";
        //                    break;
        //                }
        //            }


        //                Console.WriteLine(answers[i]);
        //            }



        //        Console.ReadKey();
        //    }




        public class Solution
        {
            public static void Main(String[] args)
            {
                string str = Console.ReadLine();
                int n = int.Parse(Console.ReadLine());
                HashSet<int> weights = getWeights(str);
                while (n-- > 0)
                {
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine(weights.Contains(x) ? "Yes" : "No");
                }
            }

            private static HashSet<int> getWeights(String str)
            {
                HashSet<int> weights = new HashSet<int>();
                int weight = 0;
                char prev = ' '; // so it doesn't match 1st character
                for (int i = 0; i < str.Length; i++)
                {
                    char curr = str[i];
                    if (curr != prev)
                    {
                        weight = 0;
                    }
                    weight += curr - 'a' + 1;
                    weights.Add(weight);
                    prev = curr;
                }
                return weights;
            }
        
    }
}
