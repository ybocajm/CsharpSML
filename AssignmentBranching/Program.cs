using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBranching
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Welcome to Package Express.  Please enter your name and follow the instructions below: ");
			string name = Console.ReadLine();
			Console.Write("Greetings " + name + ", how much does your package weigh? ");
			int weight = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Your package weighs " + weight + " lbs");
			if (weight > 50)
			{
				Console.WriteLine("Your package is to heavy to be shipped via Package Express.  Have a lovely day.");
				Console.ReadLine();
				Environment.Exit(-1);
			}
			else
			{
				Console.WriteLine("Press Enter to continue");
			}
			Console.ReadLine();
			

			Console.Write("What is the width of your package in inches? ");
			int inches = Convert.ToInt32(Console.ReadLine());
			Console.Write("What is the height of your package in inches? ");
			int height = Convert.ToInt32(Console.ReadLine());
			Console.Write("What is the length of your package in inches? ");
			int length = Convert.ToInt32(Console.ReadLine());

			int totalSize = inches * height * length;

			Console.Write("Your package's total dimension is " + totalSize + ".  ");

			decimal userQuote = (totalSize * weight) / 100;
			string quote = Convert.ToString(userQuote);

//This snippet works, but I want to try ternary
			//if (totalSize > 50)
			//{
			//	Console.WriteLine("Sorry, but your package is too big to be shipped via Package Express.");
			//	Console.ReadLine();
			//	Environment.Exit(-1);
			//}
			//else
			//{
			//	Console.WriteLine("The cost to ship your package is $" + quote + ". Please pay at the counter.");
			//}
			//Console.ReadLine();

// I'm really not sure how I can make "quote" output like currency without stringing text around it.  I tried converting decimal ToString, but that doesn't seem necessary and it doesn't work (when working with whole values anyway.)
			string result = totalSize > 50 ? "Sorry, but your package is too big to be shipped via PE." : "You owe $" + quote + ".00.  Please pay at the counter";
			Console.WriteLine(result);
			Console.ReadLine();

		}
	}
}

/*
// Write essentially the same thing using TERNARY operator
// notice string is not used for the initial readline
			Console.Write("Fave #? ");
			int favNum = Convert.ToInt32(Console.ReadLine());

			string result = favNum == 2 ? "You have an awesome fave num!" : "Your number sucks";
			Console.WriteLine(result);
			Console.ReadLine();
*/