using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Skriv din alder: ");
                string ageInput = Console.ReadLine();
                int.TryParse(ageInput, out int userAge);
                if(userAge >= 18)
                {
                    Console.WriteLine("Tilykke! Du er nu myndig");
                }
                Console.Write("Skriv dit navn: ");
                string userName = Console.ReadLine();
                int nameLenght = userName.Length;
                if(nameLenght >= 20)
                {
                    Console.WriteLine("Wow! Dit navn er langt");
                }
                Console.WriteLine($"Vi ses, {userName}");
                Console.Write("Skriv et tal mellem -20 og 20: ");
                string numberInput = Console.ReadLine();
                int.TryParse(numberInput, out int number);
                if(number < 0)
                {
                    Console.WriteLine("Nu ikke så negativ!!!");
                }
                Console.WriteLine($"Jeg synes også at {number} er et flot tal!");
                        
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
