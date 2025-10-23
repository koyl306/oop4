using System;

namespace _4pr
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
    
        public Person(string name, string role, int age)
        {
            Name = name;
            Age = age;
            Role = role;
        }
    
        public string GetName() { return Name; }
    
        public virtual void MyRating() { return; }
    }
    
    class Student : Person
    {
        public string Faculty { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }
    
        public class StudentAssesment
        {
            private double[] assessment = new double[10];
    
            public void StRating()
            {
                Random rnd = new Random();
                for (int i = 0; i < assessment.Length; i++)
                {
                    assessment[i] = rnd.Next(56, 101);
                }
            }
    
            public double MyRating()
            {
                double sum = 0;
                for (int i = 0; i < assessment.Length; i++)
                {
                    sum += assessment[i];
                }
                return Math.Round(sum / assessment.Length, 2);
            }
    
            public void ShowAssessments(string moduleName)
            {
                Console.WriteLine($"\nОцінки за {moduleName}:");
                Console.WriteLine(string.Join(", ", assessment));
            }
        }
    
        private StudentAssesment strating1 = new StudentAssesment();
        private StudentAssesment strating2 = new StudentAssesment();
    
        public Student(string name, string role, int age, string faculty, string group, int course)
            : base(name, role, age)
        {
            Faculty = faculty;
            Group = group;
            Course = course;
        }
    
        public override void MyRating()
        {
            strating1.StRating();
            strating1.ShowAssessments("Модуль 1");
            double module1 = strating1.MyRating();
            Console.WriteLine($"Середній рейтинг за модуль 1: {module1}");
    
            strating2.StRating();
            strating2.ShowAssessments("Модуль 2");
            double module2 = strating2.MyRating();
            Console.WriteLine($"Середній рейтинг за модуль 2: {module2}");
    
            double semesterAverage = Math.Round((module1 + module2) / 2, 2);
            Console.WriteLine($"\nСередній рейтинг за семестр: {semesterAverage}");
    
            if (semesterAverage >= 82)
                Console.WriteLine("Вітаємо відмінника!");
            else if (semesterAverage <= 60)
                Console.WriteLine("Перездача! Треба краще вчитися!");
            else
                Console.WriteLine("Можна вчитися ще краще!");
        }
    }
}