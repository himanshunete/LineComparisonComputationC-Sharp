using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Line Computation Program ");
            //Coordinates
            double x1 = 4;
            double y1 = 6;
            double x2 = 8;
            double y2 = 7;
            double squareX = (x2 - x1) * (x2 - x1);
            double squareY = (y2 - y1) * (y2 - y1);
            Console.WriteLine($" Length of a Line: { Math.Sqrt(squareX + squareY) }");
        } 
    }
}
