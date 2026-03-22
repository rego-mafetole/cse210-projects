using System;

namespace ScriptureMemorizer
{
    class ScriptureMemorizer

    {

        static void Main() {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son");

        Console.WriteLine(scripture.GetDisplayText());

        scripture.HideRandomWords(3);

        scripture.RevealWord(2);

        Console.WriteLine(scripture.GetDisplayText());
        }
}
}

    