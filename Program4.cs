using System;

namespace _4pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Countcountcount.FindPrimeNumbers();
            Countcountcount.GenerateRandomReals();

            double[] test = { 25.5, 30.2, 28.1, 39.9 };
            Console.WriteLine($"Середнє значення: {Countcountcount.Average(test)}");

            Console.ReadKey();
        }
    }
}