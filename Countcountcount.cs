using System;

namespace _4pr
{
    static class Countcountcount
    {
        public static void FindPrimeNumbers()
        {
            int limit = 131;
            bool[] isPrime = new bool[limit + 1];

            for (int i = 2; i <= limit; i++)
                isPrime[i] = true;

            for (int p = 2; p * p <= limit; p++)
            {
                if (isPrime[p])
                {
                    for (int j = p * p; j <= limit; j += p)
                        isPrime[j] = false;
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= limit; i++)
                if (isPrime[i]) primes.Add(i);

            Console.WriteLine("Прості числа від 1 до 131:");
            Console.WriteLine(string.Join(", ", primes));
            Console.WriteLine();
        }

        public static void GenerateRandomReals()
        {
            Random rnd = new Random();
            double[] numbers = new double[8];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Math.Round(21 + rnd.NextDouble() * (40 - 21), 2);

            Console.WriteLine("Випадкові числа (21–40):");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
        }

        public static double Average(double[] arr)
        {
            double sum = 0;
            foreach (double num in arr)
                sum += num;
            return Math.Round(sum / arr.Length, 2);
        }
    }
}