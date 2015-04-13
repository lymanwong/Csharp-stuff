using System;

namespace Module_Two_Assignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string evenLines = "XOXOXOXO";
			string oddLines = "OXOXOXOX";
			int lines = 0;
			while(lines <= 7) {
				if (lines % 2 == 0){
					Console.Write (evenLines);
					Console.WriteLine ();
					lines++;
				} else {
					Console.Write (oddLines);
					Console.WriteLine ();
					lines++;
				};
			}
		}
	}
}