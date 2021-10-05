using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonna nime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis kumb on pikem ees või perekonna nimi

            Console.WriteLine("Sisesta oma eesnimi: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi: ");
            string lastname = Console.ReadLine();

            if (firstname.Length < lastname.Length)
            {
                Console.WriteLine("Su perekonna nimi on pikem kui eesnimi.");
            }
            else if (firstname.Length > lastname.Length)
            {
                Console.WriteLine("Su eesnimi on pikem kui su perekonna nimi");
            }
            else
            {
                Console.WriteLine("Su ees- ja perekonna nimi on sama pikad");
            }

        }
    }
}
