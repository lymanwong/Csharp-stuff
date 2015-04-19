using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime_class
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString()); //returns the date and time

            //format the string
            //Console.WriteLine(myValue.ToShortDateString()); //returns just the date

            //Just time
            //Console.WriteLine(myValue.ToShortTimeString());

            //Long date string
            //Console.WriteLine(myValue.ToLongDateString()); //long and spelled out


            //See seconds as well
            //Console.WriteLine(myValue.ToLongTimeString());


            //Date math - adding values from the date
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            //Adding hours
            //Console.WriteLine(myValue.AddHours(3).ToShortTimeString());


            //subtracting
            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());

            //displaying only the month
            //Console.WriteLine(myValue.Month);

            //Creating date objects using an overload constructor
            //DateTime myBirthday = new DateTime(1976, 04, 16);
            //Console.WriteLine(myBirthday.ToShortDateString());

            //Determine difference between two difference points in time
            DateTime myBirthday = DateTime.Parse("04/16/1976");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
