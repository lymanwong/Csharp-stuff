//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//
//
//
//namespace Module_Three_Assignment
//{
//	//Create a struct to represent a student
//	struct Student
//	{
//		public string firstName { get; set; }
//		public string lastName { get; set; }
//		public string address { get; set; }
//		public string city { get; set; }
//		public string state { get; set; }
//		public string zipCode { get; set; }
//
//	}
//
//	//Create a struct to represent a teacher
//	struct Teacher
//	{
//		public string teacherFirstName { get; set; }
//		public string teacherLastName { get; set; }
//		public string teacherAddress { get; set; }
//		public string teacherCity { get; set; }
//		public string teacherState { get; set; }
//		public string teacherZipCode { get; set; }
//
//	}
//
//	//Create a struct to represent a program
//	struct Program_course
//	{
//		public string programName { get; set; }
//
//	}
//
//	//Create a struct to represent a course
//	struct Course
//	{
//		public string courseName { get; set; }
//		public int courseNumber { get; set; }
//		public int courseUnits { get; set; }
//
//	}
//
//
//
//	class Program
//	{
//		public static void Main (string[] args)
//		{
//			//Create an array to hold 5 student structs
//			object[] studentArray = new object[5];
//
//			//Assign values to the fields in at least one of the student structs in the array
//			Student student1 = new Student ();
//			student1.firstName = "Stephen";
//			student1.lastName = "Curry";
//			student1.address = "7000 Coliseum Way";
//			student1.city = "Oakland";
//			student1.state = "California";
//			student1.zipCode = "94621";
//
//			//Add the student into the studentArray
//			studentArray [0] = student1;
//
//			Console.WriteLine ("Student's first name: {0}", student1.firstName);
//			Console.WriteLine ("Student's last name: {0}", student1.lastName);
//			Console.WriteLine ("Student's mailing address: {0}, {1}, {2}, {3}", 
//				student1.address, 
//				student1.city, 
//				student1.state, 
//				student1.zipCode);
//		}
			//iterating over the array to print values
//			for(int x = 0; x < studentArray.Count(); x++) 
//			{
//				Console.WriteLine (studentArray[x].firstName);
//			}
//


//		}
//		static void GetStudentNames()
//		{
//			Console.Write ("Enter the student's first name: ");
//			string firstName = Console.ReadLine ();
//		}
//		static void GetStudentDetails()
//		{
//			Console.Write ("Enter the student's first name: ");
//			string firstName = Console.ReadLine ();
//			Console.Write ("Enter the student's last name: ");
//			string lastName = Console.ReadLine ();
//			Console.Write ("Enter the student's address: ");
//			string address = Console.ReadLine ();
//			Console.Write ("Enter the student's city: ");
//			string city = Console.ReadLine ();
//			Console.Write ("Enter the student's state: ");
//			string state = Console.ReadLine ();
//			Console.Write ("Enter the student's zip/postal code: ");
//			string zipCode = Console.ReadLine ();
//		}

//		static void PrintStudentDetails( string firstName, string lastName, string address, string city, 
//			string state, string zipCode)
//		{
//			//Using a series of Console.WriteLine() statements, 
//			//output the values for the student struct that you assigned in the previous step
//			Console.WriteLine("Student's first name: {0}", Student.firstName);
//			Console.WriteLine("Student's last name: {0}", Student.lastName);
//			Console.WriteLine ("Student's mailing address: {0}, {1}, {2}, {3}", 
//				Student.address, 
//				Student.city, 
//				Student.state, 
//				Student.zipCode);
//		}
//	}
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Three_Assignment
{
	//Create a struct to represent a student
	struct Student
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string address { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public string zipCode { get; set; }
	}
	//Create a struct to represent a teacher
	struct Teacher
	{
		public string teacherFirstName { get; set; }
		public string teacherLastName { get; set; }
		public string teacherAddress { get; set; }
		public string teacherCity { get; set; }
		public string teacherState { get; set; }
		public string teacherZipCode { get; set; }
	}

	//Create a struct to represent a program
	struct Program_course
	{
		public string programName { get; set; }
	}

	//Create a struct to represent a course
	struct Course
	{
		public string courseName { get; set; }
		public int courseNumber { get; set; }
		public int courseUnits { get; set; }
	}

	class Program
	{
		public static void Main (string[] args)
		{
			//Create an array to hold 5 student structs
			object[] studentArray = new object[5];

			//Assign values to the fields in at least one of the student structs in the array
			Student student1 = new Student ();
			student1.firstName = "Stephen";
			student1.lastName = "Curry";
			student1.address = "7000 Coliseum Way";
			student1.city = "Oakland";
			student1.state = "California";
			student1.zipCode = "94621";

			//Add the student into the studentArray
			studentArray [0] = student1;

			Console.WriteLine ("Student's first name: {0}", student1.firstName);
			Console.WriteLine ("Student's last name: {0}", student1.lastName);
			Console.WriteLine ("Student's mailing address: {0}, {1}, {2}, {3}", 
				student1.address, 
				student1.city, 
				student1.state, 
				student1.zipCode);
		}
	}
}