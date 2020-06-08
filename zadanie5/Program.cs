using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace zadanie5
{
    class Student
    {
        private string fio;
        private int id;
        private string group;
        private string data;

        ArrayList student = new ArrayList();
        ArrayList students = new ArrayList();
        public void dobavit()
        {
            Console.WriteLine("Введите данные студента.");
            Random rnd = new Random();
            id = rnd.Next(20);
            Console.WriteLine("Введите ФИО: ");
            fio = Console.ReadLine();
            Console.WriteLine("Введите Группу: ");
            group = Console.ReadLine();
            Console.WriteLine("Введите Дату рождения: ");
            data = Console.ReadLine();
            student = new ArrayList();
            student.Add(id);
            student.Add(fio);
            student.Add(group);
            student.Add(data);
            string lo = "Номер студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата рождения: " + student[3];
            students.Add(lo);
        }

        public void izmenit()
        {
            int po = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + po + " ), которого надо изменить");
            int lo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите, что нужно изменить: \n1 - ФИО\n2 - Группу\n3 - Дату рождения");
            int meow = Convert.ToInt32(Console.ReadLine());
            if (meow == 1)
            {
                Console.WriteLine("Введите ФИО: ");
                string fio = Console.ReadLine();
                student[1] = fio;
            }
            if (meow == 2)
            {
                Console.WriteLine("Введите Группу: ");
                string group = Console.ReadLine();
                student[2] = group;
            }
            if (meow == 3)
            {
                Console.WriteLine("Введите Дату рождения: ");
                string data = Console.ReadLine();
                student[3] = data;
            }
            int mr = po;

            string kri = "Номер студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата Рождения: " + student[3];
            students[lo] = kri;
        }

        public void delete()
        {
            int po = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + po + " ), которого надо удалить");
            int lo = Convert.ToInt32(Console.ReadLine());
            students.RemoveAt(po);

        }
        public void info()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + "\n");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student lo = new Student();
            lo.dobavit(); Console.WriteLine();
            lo.dobavit(); Console.WriteLine();
            lo.info(); Console.WriteLine();
            lo.delete(); Console.WriteLine();
            lo.info(); Console.WriteLine();
            lo.dobavit(); Console.WriteLine();
            lo.info(); Console.WriteLine();
            lo.izmenit(); Console.WriteLine();
            lo.info();
        }
    }

}

