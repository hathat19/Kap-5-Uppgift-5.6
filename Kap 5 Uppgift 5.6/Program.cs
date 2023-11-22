using System;
namespace Uppgift5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //-------------------------------------------

            Console.WriteLine("Skriv in heltal seperarade med asterisker \"*\". Produkten kommer räknas ut.");
            string userInput = Console.ReadLine();

            string[] nrs = userInput.Split("*");
            long product = 1;

            foreach (string nr in nrs) 
            {
                product *= int.Parse(nr);
            }

            //Utskrift
            Console.WriteLine($"Produkten av {userInput} är {product}.");
        }
    }
}

/*Skapa ett program där användaren får skriva in en rad med tal separerade med
asterisker *. Programmet ska beräkna produkten av alla talen, d.v.s. vad alla talen
multiplicerade med varandra blir. Programmet ska klara av att man skriver in minst 5
stycken fyrsiffriga tal.*/