// HW1b Grade

// Your Name:Celia
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string first = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            string last= Console.ReadLine();

            Console.WriteLine("What is your student id number?");
            int studentid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homework?");
            double homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation?");
            double participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizzes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            double final = Convert.ToDouble(Console.ReadLine());

            double finalgrade = ((homework * 0.30) + (participation * 0.10) + (quizzes * 0.10) + (midterm * 0.25) + (final * 0.25));
            Console.WriteLine(first + "" + last + " " + studentid + " Your final grade is " + finalgrade);

        }
    }
}
