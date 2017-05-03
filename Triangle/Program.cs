using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            for (int i = 0; i < count; i++)
            {
                for (int k = 0; k < i + 1; k++)
                {
                    // Здесь условие даже немного проще
                    if (k == 0 || k == i || i == count - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                // Переход на следующую строку
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
