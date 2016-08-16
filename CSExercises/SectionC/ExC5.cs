using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100�999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            int input = 0;
            bool isValidInput = false;

            while(false == isValidInput)
            {
                Console.WriteLine("Enter a no. : ");
                isValidInput = int.TryParse(Console.ReadLine(),out input);
            }

            Console.WriteLine("Number {0} is {1} number", input,
                IsArmstrongNumber(input)==true);
        }


        public static bool IsArmstrongNumber(int n)
        {
            //YOUR CODE HERE
            int remainer = 0;
            int sum = 0;

            for (int i = n; i > 0; i = i / 10) 
            {
                remainer = i % 10;
                sum = sum + remainer * remainer * remainer;
            }
            if (sum == n)
                return true;
            else return false;

        }
    }
}