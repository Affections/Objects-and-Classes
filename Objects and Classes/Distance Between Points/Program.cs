using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = ReadPoint(Console.ReadLine());
            Point p2 = ReadPoint(Console.ReadLine());

            Console.WriteLine(CalcDistance(p1,p2));



        }
  
        static double CalcDistance(Point p1, Point p2)
        {
            int sideA = Math.Abs(p1.X - p2.X);
            int sideB = Math.Abs(p1.Y - p2.Y);

            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }
        static Point ReadPoint(string input)
        {
            int[] xy = input.Split(' ').Select(int.Parse).ToArray();
            return new Point() { X = xy[0], Y = xy[1] };
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
