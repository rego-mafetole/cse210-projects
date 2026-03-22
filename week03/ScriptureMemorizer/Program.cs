using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        class ScriptureMemorizer

    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son");

        Console.WriteLine(scripture.GetDisplayText());

            scripture.HideRandomWords(3);

            scripture.RevealWord(2);

            Console.WriteLine(scripture.GetDisplayText());
        }

}

    