using System;

namespace _4pr
{
    class Program
    {
        static void Main(string[] args)
        {
            var newSt = new Student("Шевченко", "студент", 19, "МНТУ", "K31", 3);
    
            Console.WriteLine($"Прізвище: {newSt.Name}");
            Console.WriteLine($"Вік: {newSt.Age}");
            Console.WriteLine($"Факультет: {newSt.Faculty}");
            Console.WriteLine($"Група: {newSt.Group}");
            Console.WriteLine($"Курс: {newSt.Course}");
    
            newSt.MyRating();
    
            Console.ReadKey();
        }
    }
}