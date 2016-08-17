using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
            string[] w = phrase.Split();
            string r = "";
            for (int i = 0; i < w.Length; i++)
            {
                //Console.WriteLine(w[i].Substring(0,1));
                //Console.WriteLine(w[i].Substring(1, w[i].Length-1));
                string first = w[i].Substring(0, 1); // take the first letter
                int k = w[i].Length - 1; // take the rest 
                string rest = w[i].Substring(1, k);

                w[i] = first.ToUpper() + rest;
                if (i != w.Length - 1)
                {
                    r = r + w[i] + " ";
                }
                else
                {
                    r = r + w[i];
                }
            }
            return r;


        }
    }
}
