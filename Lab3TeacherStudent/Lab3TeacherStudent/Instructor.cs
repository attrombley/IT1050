using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TeacherStudent
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public string GetNameAndCourse()
        { return this.Name + " is teaching " + this.CourseName + "."; }

        public Instructor (string teacherFirstName, string courseName)
        {
            this.Name = teacherFirstName;
            this.CourseName = courseName;
        }
        public void SetStudentGrade(Student student, int graded)
        {
            student.SetGrade(graded);
        }

        public string PrintName()
        {
          return  this.Name;        
        }


        public void PrintNameAndCourse()
        {
            System.Console.WriteLine(GetNameAndCourse());
        }


    }
}
