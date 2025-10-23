using System;

namespace _4pr
{
    class Faculty
    {
        private string facultyName;

        public class Department
        {
            private string name;
            private int teachersCount;
            private string[] disciplines = new string[5];

            public void SetName(string name)
            {
                this.name = name;
            }

            public void SetTeachersCount(int count)
            {
                teachersCount = count;
            }

            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < disciplines.Length)
                        return disciplines[index];
                    else
                        return "Невірний індекс";
                }
                set
                {
                    if (index >= 0 && index < disciplines.Length)
                        disciplines[index] = value;
                }
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Кафедра: {name}, викладачів: {teachersCount}");
                Console.Write("Дисципліни: ");
                foreach (string d in disciplines)
                {
                    if (!string.IsNullOrEmpty(d))
                        Console.Write(d + "; ");
                }
                Console.WriteLine("\n");
            }
        }

        private Department dep1 = new Department();
        private Department dep2 = new Department();

        public Faculty(string name)
        {
            facultyName = name;
        }

        public void SetupDepartments()
        {
            Console.WriteLine($"Факультет: {facultyName}\n");

            dep1.SetName("Комп'ютерних наук та ІПЗ");
            dep1.SetTeachersCount(10);
            dep1[0] = "Програмування";
            dep1[1] = "Алгоритми";
            dep1[2] = "Бази даних";

            dep2.SetName("Вищої математики");
            dep2.SetTeachersCount(5);
            dep2[0] = "Математичний аналіз";
            dep2[1] = "Лінійна алгебра";

            dep1.ShowInfo();
            dep2.ShowInfo();
        }
    }
}