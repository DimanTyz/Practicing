using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_InsertionP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int value = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i-1] > value)
                {
                    arr[i] = arr[i - 1];
                }
                else if(arr[i-1] <= value)
                {
                    arr[i] = value;
                    break;
                }


                Show(arr);
            }

            if (arr[0]>value)
            {
                arr[0] = value;
            }

            Show(arr);


            Console.ReadKey();

        }
        static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
