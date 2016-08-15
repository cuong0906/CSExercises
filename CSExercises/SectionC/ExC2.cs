using System;

namespace CSExercises
{
    //Write a program that would request for your name, 
    //gender and age and would print a greeting like this:
    //Good morning Uncle Sam( if Sam, M, 45 is entered)
    //(any gentlemen 40 years or more is Uncle any lady 
    //40 years or more is Aunty, if less than forty they 
    //become just Mr or Ms. as the case may be.)


    public class ExC2
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //YOUR CODE HERE
            if (gender == "M" || gender=="m") 
            {
                if (age >= 40) { Console.WriteLine("Gud moring Uncle {0}", name); }
                else{ Console.WriteLine("Gud morning Mr.{0}", name);}
            }
            if (gender == "F" || gender == "f")
            {
                if (age >= 40) { Console.WriteLine("Gud moring Aunty {0}", name); }
                else { Console.WriteLine("Gud morning Ms.{0}", name); }
            }
        }
    }
}