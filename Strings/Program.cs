using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma eesnime
            //programm kuvaba kasutaja eesnime esimest tähte
            //programm kuvab kasutaja viimast tähte

            Console.WriteLine("Sisesta oma eesnimi: ");
            string firstname = Console.ReadLine();

            Console.WriteLine(firstname[0]);

            int firstnamelenght = firstname.Length;
            Console.WriteLine($"Teie nimi on {firstnamelenght} sümbolit pikk");

            //viimase tähe indeks = firstnamelenght - 1
            Console.WriteLine(firstname[firstnamelenght-1]);
        }
    }
}
