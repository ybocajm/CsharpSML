using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

// commented out all but System, because they weren't used.
// There are many comments because I'll refer to this (and other work) in the future.  

namespace AssignmentStudentReport
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("The Tech Academy?");
			Console.WriteLine("Student Daily Report");
			Console.WriteLine("What Course are you on?");
			string course = Console.ReadLine();
			//Console.WriteLine("Your course is " + course);
			//Console.ReadLine();
			Console.WriteLine("What page number are you on?");
			string pageNumber = Console.ReadLine();
			int page = Convert.ToInt32(pageNumber);
			// This should probably be an integer, but I'm not using it to add, so I shouldn't need to convert it.
			// If I did, how would I do it
			// Example from video: string yearsOld = currentAge.ToString();
			// How about to Integer?
			// int favNum = Convert.ToInt32(favoriteNumber);
			// string page = Convert.ToInt32(pageNumber);
			//Console.WriteLine("You're on page number " + page);
			//Console.ReadLine();
			//Console.WriteLine("Your course is: " + course);
			//Console.ReadLine();

			// convert...
			//int favNum = Convert.ToInt32(favoriteNumber);
			//int total = favNum + 5;
			//Console.WriteLine("Your favorite number + 5 = " + total);
			//Console.ReadLine();

			Console.WriteLine("You're on page " + pageNumber + " of the " + course + " course.");
			Console.ReadLine();
			Console.WriteLine("Page # + 5 = " + pageNumber + 5);
			Console.ReadLine();
			//Console.WriteLine("Page number plus 55 = ") + (page + 55);
			Console.WriteLine("Page number plus 55 = " + page + 55);
			Console.WriteLine(page + 55);
			Console.ReadLine();

			Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\"");
			string helpMe = Console.ReadLine();
			bool help = Convert.ToBoolean(helpMe);
			Console.ReadLine();
			Console.WriteLine(help);
			Console.ReadLine();

			Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics");
			string experiences = Console.ReadLine();
			Console.ReadLine();
			Console.WriteLine(experiences);
			Console.ReadLine();

			Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
			string feedback = Console.ReadLine();
			Console.ReadLine();
			Console.WriteLine(feedback);
			Console.ReadLine();

			Console.WriteLine("How many hours did you study today?");
			string hoursStudied = Console.ReadLine();
			int hours = Convert.ToInt32(hoursStudied);
			Console.ReadLine();
			Console.WriteLine(hours);
			Console.ReadLine();

			Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
			Console.ReadLine();

			// some Data Types
			//bool isStudying = false;
			//byte hoursWorked = 42;
			//sbyte currentTemp = -23'
			//char questionMark = '\u2103';
			//decimal moneyInBank = 100.5m;
			//double heightInCM = 211.30202092;
			// float, int, short (less than int) -341 for example, string

			//To display these...
			//Console.WriteLine(questionMark);
			//Console.ReadLine();

			//Convert Int to String
			//int currentAge = 30;
			//string yearsOld = currentAge.ToString();

			//Convert bool
			//bool isRaining = true;
			//string rainingStatus = Convert.ToString(isRaining);
			//Console.WriteLine(rainingStatus);
			//Console.ReadLine();

			//bool notRaining = false;
			//Console.WriteLine(notRaining);
			//Console.ReadLine();

			// Conversion can (usually) be avoided by building a website that asks for string input
			// What is your name?
			// Are you ... something?  That answer can be yes, no, yeah, YES, and it's best to be a string, OR
			// use bullet points to ask true and false, thus boolean.   
		}
	}
}
// With all the modern web technology, why are we learning to create console apps?
// Console apps are lightweight and easy to throw together to test it out.
// but a console app isn't a large-scale web app
// console apps can automate tasks (such as moving files from one folder to another)
// or parsing an xml file for addresses

// c# (unlike JS) requires specificity in declaration, so declare string, int, char, etc.