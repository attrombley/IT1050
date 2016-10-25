using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TeacherStudent
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public void SetGrade(int x)
        {
            this.Grade = x;
        }

        public Student()
        {
            Grade = 0;
        }      
        public Student(string name, Instructor theTeacher)
        {
            this.Name = name;
            this.Teacher = theTeacher;
        }

        public string AllInformation()
        {
            return this.Name + " got a " + this.Grade + " in " + this.Teacher.PrintName() + "'s class.";
        }
        public void PrintAllInformation()
        {
            System.Console.WriteLine(AllInformation());
        }

    }
}
