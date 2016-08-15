using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Eneter distance: ");
            string distanceStr = Console.ReadLine();
            double distance = Convert.ToDouble(distanceStr);

            Console.WriteLine(CalculateFare(distance));
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double charge =Math.Round((2.40 + distance) * 0.4,1);
            return charge;


        }
    }
}
