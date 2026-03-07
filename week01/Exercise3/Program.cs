using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userInput = -1;

        while (userInput != magicNumber)
        {
            Console.Write("What is the magic number? ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput > magicNumber)
            {
                Console.WriteLine("Guess Lower");
            }

            else if (userInput < magicNumber)
            {
                Console.WriteLine("Guess Higher");
            }

            else
            {
                Console.WriteLine("You have guessed it.");
            }
        }
    }
}