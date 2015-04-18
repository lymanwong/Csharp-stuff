using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // the \ is an escape character
            //string myString = "Go to your c:\\ drive";

            //double quotes in a literal string
            //string myString = "My \"so called\" life";

            //line return
            //string myString = "What if I need \n a new line?";

            //string.Format() and substitutions
            //string myString = string.Format("{0}!", "Bonzai"); //Bonzai

            //multiple substituions
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "760il"); //Model: BMW (760il)


            //formatting numbers into dollars and cents
            //string myString = string.Format("{0:C}", 123.45);  //$123.45

            //formatting numbers with a decimal
            //string myString = string.Format("{0:N}", 123456789); //123456789.00

            //formatting numbers into percentage
            //string myString = string.Format("{0:P}", .123); //12.30%

            //custom formatting using #
            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);

            //string concatination
            //This takes a lot of resources since the computer needs to allocate a another spot in the memory for the new string
            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}

            //It's better to create a class to take care of the string concatination for large number of strings
            //StringBuilder myString = new StringBuilder();

            //for (int i = 0; i < 100; i++ )
            //{
            //    myString.Append("--");
            //    myString.Append(i);
            //}

            //manipulating strings
            string myString = " That summer we took threes across the board  ";

            //Substrings
            //myString = myString.Substring(5, 14);

            //Uppercase
            //myString = myString.ToUpper();

            //Replace
            //myString = myString.Replace(" ", "--"); //replaces blanks with --

            //Adding to a string
            myString = String.Format("Length before: {0} -- After: {1}", myString.Length, myString.Trim().Length);
            
            Console.WriteLine(myString.ToString());
            Console.ReadLine();
        }
    }
}
