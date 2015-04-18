using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_with_the_if_Decision_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would you prefer what is behind door number 1,2,or 3?");
            string userValue = Console.ReadLine();

            //string message = "";

            //if (userValue == "1")
            ////{  // you can omitt curly braces for if statements only if it is followed by a single line
            //    //Console.WriteLine("You won a new car!");
            //    //Console.ReadLine();
            //    message = "You won a new car!";
            ////}
            //else if (userValue == "2")
            ////{
            //    //Console.WriteLine("You won a boat!");
            //    //Console.ReadLine();
            //    message = "You won a boat!";
            ////}
            //else if (userValue == "3")
            ////{
            //    //Console.WriteLine("You won a new dog!");
            //    //Console.ReadLine();
            //    message = "You won a new dog!";
            ////}
            //else
            ////{
            //    //Console.WriteLine("Sorry you lose!");
            //    //Console.ReadLine();
            //    message = "Sorry you lose!";
            //}

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);
            Console.ReadLine();
        }
    }
}
