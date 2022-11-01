using System;
namespace Aplicatie_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROGRAMUL CONVERTESTE ORICE NUMAR IN FORMAT DOUBLE IN INT


            Console.WriteLine("Introduceti valorile corespunzatoare pentru conversia inplicita !");

            Console.WriteLine("Introduceti prima valoare !");
            int theFristNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce-ti ultima valoare corespunzatoare !");
            double theLastNumber = double.Parse(Console.ReadLine());

            if (theFristNumber <= 0 && theLastNumber <= 0 || theLastNumber <= 0 && theLastNumber <= 0 || theFristNumber <= 0 && theFristNumber != theLastNumber || theLastNumber <= 0 && theLastNumber != theFristNumber && theFristNumber <= 0 && theFristNumber != theLastNumber)
            {
                Console.WriteLine("Valorile ce lea-ti introdus nu sunt acceptate, introduce-ti doar valori pozitive !");
                return;
            }
            else
            {
                theLastNumber = theFristNumber;

                Console.WriteLine(theLastNumber);
            }
        }
    }
}