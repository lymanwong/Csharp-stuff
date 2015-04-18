using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Expressions_and_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b; //can declare all varibles at once and at the top

            //assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //addition operator
            x = 3 + 4;
            
            //subtraction operator
            x = 4 - 3;

            // multiplication operator
            x = 10 * 5;

            //division operator
            x = 10 / 5;


            //equality operator

            if (x == y) {
            }

            //conditional AND operator
            if ((x > y) || ( a > b){

            }

            //in-lin conditional operator
            string message = (x == 1) ? "Car" : "Boat";

            // member access and method invocation
            Console.WriteLine("Hi");
        }
    }
}
