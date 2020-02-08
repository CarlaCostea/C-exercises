using System;

namespace SortByName
{
    struct Student
    {
        public string Name;
        public double Grade;

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
    }

    class Program
    {
        static void Main()
        {
            Student[] students = ReadStudents();
            QuickSort(students, 0, students.Length - 1);
            Print(students);
            Console.Read();
        }

        static void QuickSort(Student[] students, int start, int end)
            {
            int i;
            if (start >= end)
            {
                return;
            }

            i = Partition(students, start, end);

            QuickSort(students, start, i - 1);
            QuickSort(students, i + 1, end);
        }

        static int Partition(Student[] students, int start, int end)
        {
            Student temp;
            string p = students[end].Name;
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (string.Compare(students[j].Name, p, comparisonType: StringComparison.OrdinalIgnoreCase) <= 0)
                {
                    i++;
                    temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }

            temp = students[i + 1];
            students[i + 1] = students[end];
            students[end] = temp;
            return i + 1;
        }

        static void Print(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(string.Format("{0}: {1:F2}", students[i].Name, students[i].Grade));
            }
        }

        static Student[] ReadStudents()
        {
            int studentsNumber = Convert.ToInt32(Console.ReadLine());
            Student[] result = new Student[studentsNumber];

            for (int i = 0; i < studentsNumber; i++)
            {
                string[] studentData = Console.ReadLine().Split(':');
                result[i] = new Student(studentData[0], Convert.ToDouble(studentData[1]));
            }

            return result;
        }
    }
}
