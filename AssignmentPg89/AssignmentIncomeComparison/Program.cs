using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentIncomeComparison
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Anonymous Income Comparison Program");
			Console.Write("Hello, and what is your name? ");
			string person1 = Console.ReadLine();
			Console.Write("How much do you make per hour? ");
			string rate1 = Console.ReadLine();
			decimal decRate1 = Convert.ToDecimal(rate1);
			Console.Write("How many hours do you work per week? ");
			string hours1 = Console.ReadLine();
			int hoursWork1 = Convert.ToInt32(hours1);
			decimal total1 = decRate1 * hoursWork1;
			Console.WriteLine(person1 + ", you make $" + total1 + " per week.");
			Console.ReadLine();

			Console.Write("What's your name? ");
			string person2 = Console.ReadLine();
			Console.Write("How much do you make per hour? ");
			string rate2 = Console.ReadLine();
			decimal decRate2 = Convert.ToDecimal(rate2);
			Console.Write("How many hours do you work per week? ");
			string hours2 = Console.ReadLine();
			int hoursWork2 = Convert.ToInt32(hours2);
			decimal total2 = decRate2 * hoursWork2;
			Console.WriteLine(person2 + ", you make $" + total2 + " per week.");
			Console.ReadLine();

			decimal annual1 = total1 * 52;
			decimal annual2 = total2 * 52;
			decimal difference = annual2 - annual1;
			bool more1 = annual1 > annual2;

			Console.WriteLine("Annual salary of " + person1 + ":");
			Console.WriteLine(annual1);
			Console.WriteLine("Annual salary of " + person2 + ":");
			Console.WriteLine(annual2);
			Console.WriteLine("That's a difference of:");
			Console.WriteLine(difference);
			Console.WriteLine("Does " + person1 + " make more than " + person2 + "?");
			Console.WriteLine(more1);
			Console.ReadLine();

		}
	}
}
