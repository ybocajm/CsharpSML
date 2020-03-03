using System;
using System.Collections.Generic;

	class Program
	{
		static void Main(string[] args)
		{
// 1. Create a one-dimensional array of strings, take input, add to strings, print each on separate lines

		string[] names = { "Mike", "Joe", "John", "Jerry" };
		Console.Write("Type a word:  ");
		string userName = Console.ReadLine();

		for (int m = 0; m < names.Length; m++)
		{
			if (names[m] == "Mike")
			{
				Console.WriteLine(names[m] + " " + userName);
			}
			else if (names[m] == "Joe")
			{
				Console.WriteLine(names[m] + " " + userName);
			}
			else if (names[m] == "John")
			{
				Console.WriteLine(names[m] + " " + userName);
			}
			else if (names[m] == "Jerry")
			{
				Console.WriteLine(names[m] + " " + userName);
			}

		}
		Console.ReadLine();

// 2. created infinite loop by removing m++ from for loop
// 3. re-added m++ to fix infinite loop
// 4. Create a loop using < operator --- I did that in the for loop
// 5. Create loop using <=
			
// Ben said, "The simplest fix would be to not use numbers[i] in the Console.WriteLine."

		int[] numbers = { 1, 9, 15, 21, 50, 99 };

		for (int i = 1; i <= numbers.Length; i++)
		{
			if (numbers[i] > 0)

			{
				Console.WriteLine("top dog: " + numbers[i]);
			}
		}
		Console.ReadLine();



		// Instead of an if loop, just print each one to the console.  This is pretty straight forward.
		//string[] names = { "Mike", "Nicki", "Chelle", "Deb" };

		//for (int m = 0; m < names.Length; m++)
		//{
		//	Console.WriteLine(names[m]);
		//}
		//Console.ReadLine();

		//int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
		/*
										going to log to the console which ones are passing
										iterate over this array and say 85+ is passing
										create a for loop to iterate over this array

										3 conditions in the parenthesis of a for loop
										1st condition is starting value
										2nd condition is how long to do the for loop
										what do you want to do after each for loop runs (so i++)

										what you want to do with the loop is in the brackets

		 */
		//for (int i = 0; i < testScores.Length; i++)
		//{
		//	if (testScores[i] > 85)

		//	{
		//		Console.WriteLine("Passing test score: " + testScores[i]);
		//	}
		//}
		//Console.ReadLine();


		// iterations don't take up much code.

		// iterations on lists is (supposedly) easier and there's more functions allotted to them.

		/*
						 * INTEGER LIST
						 * INTEGER LIST
						 * INTEGER LIST
		 */

		//List<int> testScores = new List<int>();
		//testScores.Add(98);
		//testScores.Add(99);
		//testScores.Add(81);
		//testScores.Add(72);
		//testScores.Add(70);

		// now we're going to iterate over this list using a foreach loop

		//foreach (int score in testScores) // testScores is our list, score is an item in the list, so this will go through each item in the list
		//{
		//	if (score > 85)
		//	{
		//		Console.WriteLine("Passing test score:" + score);
		//	}
		//}
		//Console.ReadLine();

		/*
				 * STRING LIST
				 * STRING LIST
				 * STRING LIST
		 */

		//List<string> names = new List<string>() { "Mike", "Mikey", "Michael" };

		//foreach (string name in names)  // lists are typically pluralized
		//{
		//	if (name == "Mike")
		//	{
		//		Console.WriteLine(name);
		//	}
		//}
		//Console.ReadLine();

		// same as above, but print all names...
		/*
				 * PRINT ALL NAMES IN A LIST
				 * PRINT ALL NAMES IN A LIST
				 * PRINT ALL NAMES IN A LIST
		 */
		//List<string> names = new List<string>() { "Mike", "Mikey", "Michael" };

		//foreach (string name in names)
		//{
		//	Console.WriteLine(name);
		//}
		//Console.ReadLine();

		/* COMMON USAGE
		 * COMMON USAGE
		 * COMMON USAGE
		 * 
		 * Iterate over a list and if something meets a certain condition, you'll add it to another list...
		 */

		//List<int> testScores = new List<int>() { 1, 2, 3, 97, 98, 99 };
		//List<int> passingScores = new List<int>(); // this creates a blank list, which can be done with lists, not arrays (you don't have to define how big a list is)

		//foreach (int score in testScores)
		//{
		//	if (score > 85)
		//	{
		//		passingScores.Add(score);
		//	}
		//}
		//Console.WriteLine(passingScores.Count); // arrays uses length, list uses count
		//Console.ReadLine();

		// So this will output 3 (3 passing scores)


		// In summary, we have a list of test scores
		// We iterated through and got all the passing scores
		// and then we counted how many passing scores there were

		// sometimes you may want to pass this list of scores onto another part of your program or to the interface (pass it onto the user).
		// Lists can be turned into other data formats, which can be good for sending over http or a json object(?)

		// apparently we'll do this a lot, so it'll be easier.  We'll see.
	}
}
