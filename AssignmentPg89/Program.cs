using System;

namespace AssignmentPg89
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your favorite number?");
			string userNumber = Console.ReadLine();
			int number = Convert.ToInt32(userNumber);
			int product = number * 50;
			Console.WriteLine("Your number * 50 = " + product);
			//Console.ReadLine();

			Console.WriteLine("Input a different number");
			string userNumber2 = Console.ReadLine();
			int number2 = Convert.ToInt32(userNumber2);
			int addIt = number2 + 25;
			Console.WriteLine("Your number + 25 = " + addIt);
			//Console.ReadLine();

			Console.WriteLine("Input a value between 100 and 500");
			string userNumber3 = Console.ReadLine();
			int number3 = Convert.ToInt32(userNumber3);
			int divideIt = number3 / 12;
			Console.WriteLine("Your number divided by 12 = " + divideIt);
			//Console.ReadLine();

			Console.WriteLine("Input a different value between 100 and 500");
			string userNumber4 = Console.ReadLine();
			double number4 = Convert.ToInt32(userNumber4);
			double divideIt2 = number4 / 12.5;
			Console.WriteLine("Your number divided by 12.5 = " + divideIt2);
			//Console.ReadLine();


			Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\"");
			string helpMe = Console.ReadLine();
			bool help = Convert.ToBoolean(helpMe);
			Console.ReadLine();
			Console.WriteLine(help);
			//Console.ReadLine();

			bool isStudying = true;
			Console.WriteLine("studying? " + isStudying);
			Console.ReadLine();

			//Convert bool
			bool isRaining = false;
			string rainingStatus = Convert.ToString(isRaining);
			Console.WriteLine("raining? " + rainingStatus);
			Console.ReadLine();

			Console.WriteLine("Type a number greater than 50");
			string userNumber5 = Console.ReadLine();
			int number5 = Convert.ToInt32(userNumber5);
			bool numero = number5 > 50;
			Console.WriteLine("Is your number greater than 50? " + numero);
			//Console.WriteLine(numero);
			//Console.ReadLine();
			// Not sure if this is the exact format you're looking for, but it works.  If I type 49 it's false.

			Console.WriteLine("Enter a number");
			string userNumber6 = Console.ReadLine();
			int divNumber = Convert.ToInt32(userNumber6);
			int quotientRem = divNumber % 7;
			Console.WriteLine("The remainder of " + divNumber + " divided by 7 = " + quotientRem);
			Console.ReadLine();

		}
	}
}

