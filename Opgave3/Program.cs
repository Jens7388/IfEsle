using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                //vælg en af de tre muligheder
                Console.WriteLine("Hej! Vælg venligst en af følgende muligheder:");
                Console.WriteLine("1. Indtast to tal og se om de er ens.");
                Console.WriteLine("2. Divider to tal med hinanden.");
                Console.WriteLine("3. Se momsen på et beløb.");
                string select = Console.ReadLine();
                if(select == "1")
                {
                    //se om de to tal er ens
                    Console.WriteLine("Indtast 2 tal:");
                    Console.Write("Indtast første tal:");
                    string firstNumberInput = Console.ReadLine();
                    int.TryParse(firstNumberInput, out int firstNumber);
                    Console.Write("Indtast andet tal:");
                    string secondNumberInput = Console.ReadLine();
                    int.TryParse(secondNumberInput, out int secondNumber);

                    if(firstNumber == secondNumber)
                    {
                        Console.WriteLine("De to tal er ens\n");
                    }
                    else
                    {
                        Console.WriteLine("De to tal er ikke ens\n");
                    }
                }
                else if(select == "2")
                {
                    //divider to tal
                    Console.WriteLine("Indtast de 2 tal, som skal divideres:");
                    Console.Write("Indtast første tal:");
                    string thirdNumberInput = Console.ReadLine();
                    double.TryParse(thirdNumberInput, out double thirdNumber);
                    Console.Write("Indtast andet tal:");
                    string fourthNumberInput = Console.ReadLine();
                    double.TryParse(fourthNumberInput, out double fourthNumber);
                    if(thirdNumber == 0 || fourthNumber == 0)
                    {
                        Console.WriteLine("Fejl! Du kan ikke dividere med 0");
                    }
                    else
                    {
                        double result = thirdNumber / fourthNumber;
                        Console.WriteLine($"{thirdNumber} / {fourthNumber} = {result}");
                    }
                }
                else if(select == "3")
                {
                    //udregn moms
                    Console.Write("Indtast et beløb, og se dets moms: ");
                    string amountInput = Console.ReadLine();
                    double.TryParse(amountInput, out double amount);
                    if(amount > 0)
                    {
                        Console.WriteLine($"Momsen af {amount} kr er: {amount * 0.25} kr");
                    }
                    else
                    {
                        Console.WriteLine("Fejl! beløbet skal være et tal.");
                    }
                }
                else
                {
                    Console.WriteLine("Fejl! Du skal vælge 1, 2 eller 3");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
