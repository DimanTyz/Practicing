using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[] text = Console.ReadLine().ToCharArray();
            int k = int.Parse(Console.ReadLine()) % 26;

            for(int item = 0; item < text.Length; item++)
            {
                if ((int)text[item]>64 && text[item]<91)
                {
                    if (text[item] + k < 91)
                    {
                        text[item] = Convert.ToChar((int)text[item] + k);
                    }
                    else
                        text[item] = Convert.ToChar((int)text[item] + k - 26);
                }
                else if ((int)text[item] > 96 && text[item] < 123)
                {
                    if (text[item] + k < 123)
                    {
                        text[item] = Convert.ToChar((int)text[item] + k);
                    }
                    else
                        text[item] = Convert.ToChar((int)text[item] + k - 26);
                }
                Console.Write(text[item]);
            }

            Console.ReadKey();
        }
    }
}
