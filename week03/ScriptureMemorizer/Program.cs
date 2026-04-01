using System;
// Addded other scripture to make the user have options of scripture to study and loop through the scripture //

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        {
            List<Scripture> library = new List<Scripture>();

            library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart; and lean not unto thine own understanding."));
            library.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son."));
            library.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."));
            library.Add(new Scripture(new Reference("Isaiah", 60, 22), "A little one shall become a thousand, and a small one a strong nation: I the Lord will hasten it in his time."));
            library.Add(new Scripture(new Reference("Matthew", 5, 8), "Blessed are the pure in heart: for they shall see God."));

            Random _random = new Random();

            while (true)
            {
                int index = _random.Next(library.Count);
                Scripture scripture = library[index];
    
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine();

                    if (scripture.IsCompletelyHidden())
                    {
                        break;
                    }

                    Console.WriteLine("Press Enter to hide words, type 'reveal' to show, or 'quit' to exit.");
                    string input = Console.ReadLine();

                    if (input == "quit" || input == "QUIT" || input == "Quit")
                    {
                        break;
                    }
                    else if (input == "reveal" || input == "REVEAL" || input == "Reveal")
                    {
                        scripture.RevealWords(3);
                    }
                    else
                    {
                        scripture.HideRandomWords(3);
                    }
                }
            }
        }
    }
}
   