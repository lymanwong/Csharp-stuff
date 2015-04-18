using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_and_assignments_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            */

            //string myFirstName;
            //myFirstName = "Lyman";

            //string myFirstName = "Lyman";
            
            //var needs to equal something so that the compiler will know what type var is
            //var myFirstName = "Lyman";


            //implicit data conversion of 7 .ToString()
            int x = 7;
            //string y = "Lyman";
            string y = "5";
            string myFirstTry = x + y; // "7Lymam"

            // int mySecondTry = x + y; //will not work
            int mySecondTry = x + int.Parse(y);
            
            //Console.WriteLine(myFirstTry);
            Console.WriteLine(mySecondTry);

            Console.ReadLine();
        }
    }
}
