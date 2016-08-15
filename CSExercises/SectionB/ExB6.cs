using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Enter x and y for point 1 ");
            String x1Str = Console.ReadLine();
            double x1 = Convert.ToDouble(x1Str);
            String y1Str = Console.ReadLine();
            double y1 = Convert.ToDouble(y1Str);
            Console.Write("Enter x and y for point 2 ");
            String x2Str = Console.ReadLine();
            double x2 = Convert.ToDouble(x2Str);
            String y2Str = Console.ReadLine();
            double y2 = Convert.ToDouble(y2Str);

            Console.WriteLine("The distance is {0}",CalculateDistance(x1,y1,x2,y2));

        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            return Math.Sqrt((Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)));
        }
    }
}
