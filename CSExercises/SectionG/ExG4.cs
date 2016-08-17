using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE

            string[] name = new string[] { "John", "Venkat", "Marry", "Victor", "Betty" };
            int[] mark = new int[] {63,29,75,82,55};
            int[] newMark = Sort(mark);
            PrintMark(newMark);
            string[] newName = SortName(name);
            PrintName(name);
        }
        public static void PrintName(string[] name) 
        {
            Console.Write("{");
            for (int l = 0; l < name.Length; l++) 
            {
                Console.Write(name[l] + " ");
            }
            Console.WriteLine("}");
        }
        public static void PrintMark(int[] mark) 
        {
            Console.Write("{");
            for (int k = 0; k < mark.Length; k++)
            { Console.Write(mark[k] + " ");
            }
            Console.WriteLine("}");
        }
        public static string[] SortName(string[] name) 
        {
            for (int a = 0; a < name.Length-1; a++) 
            {
                for (int b = a + 1; b < name.Length; b++)
                {
                    if (name[a].CompareTo(name[b]) >0)
                    {
                        string tmp1 = name[a];
                        name[a] = name[b];
                        name[b] = tmp1;
                    }
                }
            }
                return name;
        }
        public static int[] Sort(int[] mark) 
        {
            for (int i = 0; i < mark.Length - 1; i++)
            {
                for (int j = i + 1; j < mark.Length; j++)
                {
                    if (mark[i] < mark[j])
                    {
                        int tmp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = tmp;
                    }
                }
            }
            return mark;
        }
    }
}
