using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Spouse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person.Count = 0;

            Person p1 = new Person();
            Person.Count++;

            Console.WriteLine("Hello Person #1. What is your Age?");
            p1.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your First Name?");
            p1.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            p1.LastName = Console.ReadLine();

            p1.Spouse = new Person();
            Person.Count++;

            Console.WriteLine("What is your spouse's age?");
            p1.Spouse.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your spouse's first name?");
            p1.Spouse.FirstName = Console.ReadLine();

            p1.Spouse.LastName = p1.LastName;
            p1.Spouse.Spouse = p1;


            Person p2 = new Person();
            Person.Count++;

            Console.WriteLine("Please answer the following on behalf of Person #2. What is your Age?");
            p2.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your First Name?");
            p2.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            p2.LastName = Console.ReadLine();

            p2.Spouse = new Person();
            Person.Count++;

            Console.WriteLine("What is your spouse's age?");
            p2.Spouse.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your spouse's first name?");
            p2.Spouse.FirstName = Console.ReadLine();

            p2.Spouse.LastName = p2.LastName;
            p2.Spouse.Spouse = p2;

            Person.SumOfAllAges = p1.Spouse.Age + p1.Age + p2.Age + p2.Spouse.Age;
            Person.AverageAge = Person.SumOfAllAges / Person.Count;

            Console.WriteLine("[  Printing Results  ]");

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();

            Console.WriteLine("Average Age = " + Person.AverageAge);



            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
