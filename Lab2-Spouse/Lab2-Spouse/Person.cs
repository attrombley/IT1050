using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Spouse
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public string GetFullNName()
        {
            return FirstName + " " + LastName;
        }
        public void PrintNameAndAge()
        {
            Console.WriteLine(LastName + "' " + FirstName + " " + "(" + Age + ")");
        }
    }
}
