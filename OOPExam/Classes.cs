using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    // Abstract
    abstract class Person
    {
        public string Name { get; set; }

        public abstract void ShowInfo();
    }

    // Student
    class Student : Person
    {
        private string studentId;
        private int score;

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Grade { get; set; }

        public Student(string name, string id, int score)
        {
            Name = name;
            StudentId = id;
            Score = score;
            Grade = "";
        }

        public override void ShowInfo()
        {
            Console.WriteLine(
                $"Name: {Name} | ID: {StudentId} | Score: {Score} | Grade: {Grade}"
            );
        }
    }

    // Course
    class Course
    {
        public string CourseName { get; set; }

        public List<Student> students = new List<Student>();

        public Course(string name)
        {
            CourseName = name;
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void ShowAll()
        {
            foreach (var s in students)
            {
                s.ShowInfo();
            }
        }

        public void ShowMaxMin()
        {
            if (students.Count == 0) return;

            int max = students[0].Score;
            int min = students[0].Score;

            foreach (var s in students)
            {
                if (s.Score > max) max = s.Score;
                if (s.Score < min) min = s.Score;
            }

            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }

        public void ShowAverage()
        {
            if (students.Count == 0) return;

            int sum = 0;

            foreach (var s in students)
            {
                sum += s.Score;
            }

            Console.WriteLine("Average = " + (sum / students.Count));
        }
    }

    // Grade
    class GradeCalculator
    {
        public static string GetGrade(int score)
        {
            if (score >= 80) return "A";
            else if (score >= 75) return "B+";
            else if (score >= 70) return "B";
            else if (score >= 65) return "C+";
            else if (score >= 60) return "C";
            else if (score >= 55) return "D+";
            else if (score >= 50) return "D";
            else return "F";
        }
    }
}
