using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_MaximalTourism
{
    class Program
    {
        static Route[] routes;

        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            routes = new Route[nm[1]];

            for (int i = 0; i < routes.Length; i++)
            {
                routes[i] = new Route(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            }


            int[] cities = new int[nm[0]];
            for (int i = 0; i < cities.Length; i++)
            {
                cities[i] = i + 1;
            }


            List<Route> ro = new List<Route>(routes);

            int[] counts = new int[cities.Length];

            for (int i = 0; i < counts.Length; i++)
            {
                counts[i] = FindDepth(ro, cities[i]);
            }
           


            Console.ReadKey();
        }
        static int FindDepth(List<Route> routes, int element)
        {
            for (int i = 0; i < routes.Count; i++)
            {
                
            }
        }
    }

    class Route
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Route(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Route(int[] arr)
        {
            X = arr[0];
            Y = arr[1];
        }
    }


}
