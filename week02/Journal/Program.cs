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
            Console.WriteLine("5. Search by date");
            Console.WriteLine("6. Quit");

            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Enter prompt:{prompt}");
                    Console.Write("Enter response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    journal.Load(filename);
                    Console.WriteLine("Journal loaded");
                    break;

                case "4":
                    journal.Save(filename);
                    Console.WriteLine("Journal Saved.");
                    break;

                case "5":
                    journal.SearchEntriesByDate();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}