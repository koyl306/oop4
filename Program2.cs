using System;

namespace _4pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty cult = new Faculty("ІПЗ");
            cult.SetupDepartments();

            Console.ReadKey();
        }
    }
}