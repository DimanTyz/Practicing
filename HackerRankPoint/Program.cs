using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {

        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
       
        int n = int.Parse(Console.ReadLine());

        Point[] allpoints = new Point[n*2];
        Point temp, temp1;
        string[] tempstr = new string[4];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            tempstr = Console.ReadLine().Split(' ');
            temp = new Point(Convert.ToInt32(tempstr[0]), Convert.ToInt32(tempstr[1]));
            temp1 = new Point(Convert.ToInt32(tempstr[2]), Convert.ToInt32(tempstr[3]));
            
            allpoints[k] = temp;
            allpoints[k + 1] = temp1;
            k += 2;          
        }
        List<Point> rezpoints = new List<Point>();
        for (int i = 0; i < allpoints.Length - 1; i+=2)
        {
            temp = new Point((allpoints[i + 1].X*2 - allpoints[i].X), (allpoints[i + 1].Y*2 - allpoints[i].Y));
            rezpoints.Add(temp);
        }

        foreach (var item in rezpoints)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();

    }
}
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return X + " " + Y;
    }
}
