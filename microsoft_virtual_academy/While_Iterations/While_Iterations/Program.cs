using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader myReader = new System.IO.StreamReader("values.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            myReader.Close();
            Console.ReadLine();
        }
    }
}
