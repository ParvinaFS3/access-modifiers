using System;
using System.Linq;


namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(string.Join(", ", st.Grades)); // Çıxış: 2, 4, 6, 8
        }
        class Student
        {
            private int[] grades;

            public int[] Grades
            {
                get { return grades; }
                set { grades = value.Where(x => x % 2 == 0).ToArray(); }
            }
        }
    }
}
