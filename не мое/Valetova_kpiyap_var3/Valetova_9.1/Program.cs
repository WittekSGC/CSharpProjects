using System;

namespace Valetova_9._1
{
    struct Student
    {
        public string fio;
        public int gr_number;
        public int[] usp;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            Console.WriteLine("Введите ФИО студента, номер группы, а затем 5 оценок успеваемости студента");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("ФИО учащегося №{0}: ", i+1); students[i].fio = Console.ReadLine();
                Console.Write("Номер группы учащегося №{0}: ", i+1); students[i].gr_number = int.Parse(Console.ReadLine());
                students[i].usp = new int[5]; 
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Оценка №{0} учащегося №{1}: ",j + 1, i + 1);
                    students[i].usp[j] = int.Parse(Console.ReadLine());
                }
            }


            //сортировка по алфавиту(работает криво, если будут траблы - просто сотри ее)
            int count = 0; Student temp = new Student();
            for (int i = 0; i < 9; i++)
            {
                for (int j = i+1; j < 10; j++)
                {   
                    if (students[i].fio[count] == students[j].fio[count]) count++;
                    else
                    {
                        if (students[i].fio[count]>students[j].fio[count])
                        {
                            temp = students[i];
                            students[i] = students[j];
                            students[j] = temp;
                        }
                    }
                }
                count = 0;
            }
            //здесь конец моей сортировки

            bool end = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (students[i].usp[j]<4)
                    {
                        Console.WriteLine(students[i].fio + " - " + students[i].gr_number);
                        end = true;
                    }
                }
            }
            if (end == false) Console.WriteLine("Студентов с отметкой ниже 4 нет в данном списке");

            Console.ReadKey();
        }
    }
}
