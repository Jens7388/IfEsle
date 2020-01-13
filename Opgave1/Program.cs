using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast et tal mellem 1 og 20: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int number);

                if(number == 10)
                {
                    Console.WriteLine("Tallet er lige med 10");
                }
                else if(number < 10 && number >= 1)
                {
                    Console.WriteLine("Tallet er mindre end 10");
                }
                else if(number > 10 && number <= 20)
                {
                    Console.WriteLine("Tallet er større end 10");
                }
                else
                {
                    Console.WriteLine("Du skrev ikke et tal mellem 1 og 20, prøv igen");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
