using System;

class Program
{

    Reference reference = new Reference("John", 3, 16);
    Scripture scripture = new Scripture(Reference, "For God so loved the world that he gave his only begotten Son");

    static void Main(string[] args)
    {



            Console.WriteLine(Scripture.GetDisplayText());

                Scripture.HideRandomWords(3);

                Scripture.RevealWord(2);

                Console.WriteLine(Scripture.GetDisplayText());
    }
}
    