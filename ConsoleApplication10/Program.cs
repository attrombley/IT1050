using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;
            
            Console.WriteLine("What is your first name?");

            firstName = Console.ReadLine();

            Console.WriteLine("What is your middle initial?");

            middleInitial = Console.ReadLine();

            Console.WriteLine("What is your last name?");

            lastName = Console.ReadLine();

            fullName = firstName +" "+ middleInitial +". "+ lastName;

            Console.WriteLine("Your name is: "+fullName);

            Console.WriteLine("What is your height in feet?");

            heightFeet = int.Parse(System.Console.ReadLine());

            Console.WriteLine("How many inches more than that amount of feet does your height measure?");

            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            Console.WriteLine("Your height in CM is: "+totalHeightCM);

            Console.WriteLine("How old are you?");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you a citizen? (Answer true or false)");

            isCitizen = bool.Parse(Console.ReadLine());

            canVote = (isCitizen && (age >= 18));

            Console.WriteLine("Are you eligible to vote?:"+canVote);

            Console.ReadLine();
        }
    }
}
