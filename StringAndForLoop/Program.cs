using System;

namespace StringAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi: ");
            string firstname = Console.ReadLine();

            for(int i = 0; i < firstname.Length; i++)
            {
                Console.WriteLine(firstname[i]);
            }


        }
    }
}
