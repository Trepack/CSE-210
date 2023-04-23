using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade for the class?");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        
        string letter = "";

        if (grade >= 90)
            {
                letter = "A";
            }
        else if (grade >= 80)
            {
                letter = "B";
            }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter} ");
        if (grade >= 70)
            {
                Console.WriteLine("You Passed!");
            }
        else
            {
                Console.WriteLine("Better luck next time!");
            }
    }
}