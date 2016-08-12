using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string inputString = Console.ReadLine();
            double inputDbl = Convert.ToDouble(inputString);

            double result = SQRT(inputDbl);
            Console.WriteLine(result);
        }

        public static double SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x
            Console.WriteLine("{0:##0.000}",Math.Sqrt(x));
            return 0;

        }
    }
}
