using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace OOPExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("OOP");

            while (true)
            {
                Console.WriteLine("\n1.Add Student");
                Console.WriteLine("2.Show All");
                Console.WriteLine("3.Max Min");
                Console.WriteLine("4.Average");
                Console.WriteLine("5.Exit");

                Console.Write("Choose: ");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("ID: ");
                    string id = Console.ReadLine();

                    Console.Write("Score: ");
                    int score = int.Parse(Console.ReadLine());

                    Student s = new Student(name, id, score);

                    s.Grade = GradeCalculator.GetGrade(score);

                    course.AddStudent(s);
                }

                else if (ch == 2)
                {
                    course.ShowAll();
                }

                else if (ch == 3)
                {
                    course.ShowMaxMin();
                }

                else if (ch == 4)
                {
                    course.ShowAverage();
                }

                else if (ch == 5)
                {
                    break;
                }
            }
        }
    }
}