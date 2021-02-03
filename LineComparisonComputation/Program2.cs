using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Line Computation Program ");
            //Coordinates
            //Coordinates of Line1
            double x1x = 4;
            double y1x = 6;
            double x2x = 8;
            double y2x = 7;

            //Coordinates of Line2
            double x1y = 4;
            double y1y = 6;
            double x2y = 8;
            double y2y = 7;
            double squareXx = (x2x - x1x) * (x2x - x1x);
            double squareYx = (y2x - y1x) * (y2x - y1x);
            double squareXy = (x2y - x1y) * (x2y - x1y);
            double squareYy = (y2y - y1y) * (y2y - y1y);
            double lengthOfLine1 = Math.Sqrt(squareXx + squareYx);
            double lengthOfLine2 = Math.Sqrt(squareXy + squareYy);
            if (lengthOfLine1 == lengthOfLine2)
            {
                Console.WriteLine("Length of Two Lines are Equal");
            }
            else
            {
                Console.WriteLine("Length of Two Lines are not Equal");
            }
        } 
    }
}
