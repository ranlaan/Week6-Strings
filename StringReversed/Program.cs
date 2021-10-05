using System;

namespace StringReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal siesestada eesnimi
            //programm kuvab kasutajanime tagurpidi

            Console.WriteLine("Sisesta eesnimi: ");
            string firstname = Console.ReadLine();

            for(int i = firstname.Length - 1; i >= 0; i--)
            {
                Console.Write(firstname[i]);
            }



        }
    }
}
