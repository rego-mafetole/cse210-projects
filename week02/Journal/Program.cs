using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filename = "journal.txt";

        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter prompt: ");
                    string prompt = Console.ReadLine();
                    Console.Write("Enter response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    journal.Save(filename);
                    Console.WriteLine("Journal Saved.");
                    break;

                case "4":
                    journal.Load(filename);
                    Console.WriteLine("Journal loaded");
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}