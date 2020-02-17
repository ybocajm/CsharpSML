using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBoolean
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to our online insurance acceptance check");
			Console.Write("What is your name? ");
			string name = Console.ReadLine();
			Console.Write("What is your age? ");
			string personAge = Console.ReadLine();
			int age = Convert.ToInt32(personAge);
			// Console.Write("Your age is " + age);
			// Console.ReadLine();

			bool checkAge = age >= 21;

			// Console.WriteLine("Are you at least 21 years of age? ");
			// Console.Write(checkAge);
			// Console.ReadLine();

			Console.Write("Type \"true\" or \"false\", have you ever had a DUI? ");
			string personDUI = Console.ReadLine();
			bool checkDUI = Convert.ToBoolean(personDUI);
			// Console.Write(personDUI);
			// Console.ReadLine();

			// Console.Write(checkDUI);

			Console.Write("How many speeding tickets do you have? ");
			string personTickets = Console.ReadLine();
			int tickets = Convert.ToInt32(personTickets);
			Console.ReadLine();

			bool checkTickets = tickets < 3;

			Console.Write(name + ", we have run analysis on the information you've provided.  Do you qualify for insurance with us? ");
			Console.Write(checkAge && checkDUI == false && checkTickets);
			Console.Read();
		}
	}
}
