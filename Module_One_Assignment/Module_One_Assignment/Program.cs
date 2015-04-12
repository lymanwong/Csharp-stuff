using System;

namespace Module_One_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Ask for user's first name
			Console.WriteLine("What is your first name?");
			// First Name
			//string firstName = "Lyman";
			// Assign response to a variable
			string firstName = Console.ReadLine();

			// Ask for users' last name
			Console.WriteLine("What is your last name?");
			// Assign response to a variable
			string lastName = Console.ReadLine();
			// Last Name
			//string lastName = "Wong";
			// Birthdate

			Console.WriteLine("What is your birthdate?");
			string birthDate = Console.ReadLine();
			//string birthDate= "4/16/1976";
			// Address

			Console.WriteLine ("What is your address number?");
			string addressNumber = Console.ReadLine();
			//string addressNumber = "1313";

			Console.WriteLine ("What is your address' street name?");
			string addressName = Console.ReadLine();
			//string addressName = "Mockingbird Lane";

			// City
			Console.WriteLine("Which city do you live in?");
			string city = Console.ReadLine();
			//string city = "San Francisco";

			// State/Provience
			Console.WriteLine("Which state do you live in?");
			string state = Console.ReadLine();
			//string state = "California";

			// Zip/Postal
			Console.WriteLine("What is your Zip/Postal code?");
			string zip = Console.ReadLine();
			//int zip = 94116;

			// Country
			Console.WriteLine("Which country do you live in?");
			string country = Console.ReadLine();
			//string country = "USA";

			// Other
			Console.WriteLine("What is the name of the college you went to?");
			string collegeName = Console.ReadLine();
			Console.WriteLine("What is the name of the degree you currently have or working on?");
			string degree = Console.ReadLine();
			//string collegeName = "San Francisco State";
			//string degree = "BA General Biology";

			Console.WriteLine("Name: {0} {1}", firstName, lastName);
			Console.WriteLine ("Birthdate: " + birthDate);
			Console.WriteLine ("Address: {0} {1}", addressNumber, addressName);
			Console.WriteLine ("City: " + city);
			Console.WriteLine ("State: " + state);
			Console.WriteLine ("Zipcode: " + zip.ToString());
			Console.WriteLine ("Country: " + country);
			Console.WriteLine ("College " + collegeName);
			Console.WriteLine ("Major: " + degree);

		}
	}
}
