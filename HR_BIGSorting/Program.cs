using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_BIGSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Length > arr[j+1].Length)
                    {
                        Swap(arr, j, j + 1);
                    }

                    else if(arr[j].Length == arr[j + 1].Length)
                    {




                        for (int k = 0; k < arr[j].Length; k++)
                        {
                            if (arr[j][k] > arr[j + 1][k])
                            {
                                Swap(arr, j, j + 1);
                                break;
                            }
                            else if (arr[j][k] < arr[j + 1][k])
                                break;
                        }






                    }
                   
                }
            }


            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int k = 0; k < arr.Length - i - 1; k++)
            //    {
            //        if (arr[k].Length == arr[k + 1].Length)
            //        {
                        
            //        }
            //    }
            //}   

            // Console.WriteLine(new string('-',20));

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();

        }

        static void Swap(string [] arr, int left, int right)
        {
            string temp = arr[right];
            arr[right] = arr[left];
            arr[left] = temp;
        }

    }
}
