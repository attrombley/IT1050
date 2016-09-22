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
            Person p1 = new Person();

            Console.WriteLine("What is your Age?");
            p1.Age = Console.Parse();

            Console.WriteLine("What is your Age?");
            p1.FirstName = Console.ReadLine();

            Console.WriteLine("What is your Spouse's last name?");
            p1.LastName = Console.ReadLine();

            p1.Spouse = new Person();

            Console.WriteLine("What is your Spouse's age?");
            p1.Spouse.Age = Console.ReadLine();

            Console.WriteLine("What is your Age?");
            p1.Spouse.FristName = Console.ReadLine();

            p1.Spouse.LastName = p1.LastName;
            p1.Spouse.Spouse = p1;




            Person p2 = new Person();

            public static double SumOfAllAges();
           }
     }
}
