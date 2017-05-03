using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Staircase
{
    


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            RightSideStairCase(n);

            Console.WriteLine(new string('-',20));

            LeftSideStairCase(n);

            Console.WriteLine(new string('-', 20));

            Pyramida(n);



            Console.ReadKey();
        }

        public static void RightSideStairCase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n - 1)
                    {
                        Console.Write('#');
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public static void LeftSideStairCase(int n)
        {
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i + j >= n - 1)
                        {
                            Console.Write('#');
                        }
                        //else
                        //    Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void Pyramida(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n - 1)
                    {
                        Console.Write('#');
                    }
                    //else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }

    
}
