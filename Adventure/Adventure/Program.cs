using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
                String CharacterName = "Beth";

                Console.WriteLine("Areys Creations!");
                Console.WriteLine(" A girl that creates different things to explore her creativiety.");
                Console.WriteLine("What is your name?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Great to meet you " + CharacterName);
            Console.ReadKey();
        }
    }
}
