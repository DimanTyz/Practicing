using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] tempar = new string[2];
            for (int i = 0; i < n; i++)
            {
                tempar = Console.ReadLine().Split(' ');
                phonebook.Add(tempar[0], tempar[1]);
            }

            string temp;
            while (true)
            {
                //try
                //{
                //    temp = Console.ReadLine();
                //}
                //catch (Exception)
                //{

                //    break;
                //}
                temp = Console.ReadLine();

                if (!string.IsNullOrEmpty(temp))
                {
                    if (phonebook.ContainsKey(temp))
                    {
                        Console.WriteLine("{0}={1}", temp, phonebook[temp]);
                    }
                    else
                        Console.WriteLine("Not found");
                }
                else
                    break;
               
            }

            Console.ReadKey();
        }
    }
}
