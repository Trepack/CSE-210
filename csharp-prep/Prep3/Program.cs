using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is the magic number? ");
        int magicnumber = int.Parse (Console.ReadLine());
        Console.WriteLine("what is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        

        while (guess != magicnumber)
        {
            
            if (guess > magicnumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess < magicnumber)
            {
                Console.WriteLine("higher");
            }
            else 
            {
                Console.WriteLine("you guessed right!");
            }
        }
    }
}