using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5]; //initialize the array max capacity of 5
            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;
            //numbers[5] = 42; //will throw an error bc you're trying to add 6 numbers into an array that can only hold 5. 

            //int[] numbers = new int[] { 4,8,15,16,23,42}; //initialize array and set capacity with 5 also

            //Console.WriteLine(numbers[1].ToString());
            //Console.ReadLine();

            //string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
                
            //}
            //Console.ReadLine();

            string zig = "You can have a long string " +
                "by using the plus key.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.Write(zigChar);
            Console.ReadLine();
        }
    }
}
