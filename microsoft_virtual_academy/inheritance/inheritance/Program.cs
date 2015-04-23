using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
	class Program
	{
		public static void Main (string[] args)
		{
			Car myCar = new Car ();
			myCar.Make = "BMW";
			myCar.Model = "745li";
			myCar.Color = "Black";
			myCar.Year = 2005;

			printVehicleDetails (myCar);

			Truck myTruck = new Truck ();

			myTruck.Make = "Ford";
			myTruck.Model = "F950";
			myTruck.Year = 2006;
			myTruck.Color = "Blue";
			myTruck.TowingCapacity = 1200;

			printVehicleDetails (myTruck);
			Console.ReadLine ();
		}

		private static void printVehicleDetails(Vehicle vehicle)
		{
			Console.WriteLine("Here are the Vehicle's details: {0}", vehicle.FormatMe());
		}
	}


	abstract class Vehicle //adding an abstract class allows you to derive other classes from it (pattern)
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		public abstract string FormatMe();
	}

	class Car : Vehicle
	{
		//taking all this out and adding it to Vehicle
//		public string Make { get; set; }
//		public string Model { get; set; }
//		public int Year { get; set; }
//		public string Color { get; set; }

		public override string FormatMe() 
		//adding 'virtual' says that the method can be overridden
		//adding 'abstract' means that you have to change the method if you want to use it
		{ 
			return String.Format ("{0} - {1} - {2} - {3}",
				this.Make,
				this.Model,
				this.Color,
				this.Year);
		}
	}

	sealed class Truck : Vehicle //'sealed' prevents users from creating another instance of truck
	{
		public int TowingCapacity {get; set;}

		public override string FormatMe() //adding 'override' says that you are going to change the method
		{
			return String.Format ("{0} - {1} - {2} Towing units", //overriding the format here
				this.Make,
				this.Model,
				this.TowingCapacity);
		}
	}
}
