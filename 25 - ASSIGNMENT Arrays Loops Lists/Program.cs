using System;
using System.Collections.Generic;

	class Program
	{
		static void Main(string[] args)
		{

/* NOTE
 * NOTE
 * NOTE
 * 
 * I used different variables along the way hoping to run all these at the same time, but of course #2 is an infinite loop and 
 * I'm pretty sure #11 repeats prior variables, so you'll have to comment some of these out to run them.
 */


// 1. Create a one-dimensional array of strings, take input, add to strings, print each on separate lines

		string[] names = { "Mike", "Joe", "John", "Jerry" };
		Console.Write("Type a word:  ");
		string userName = Console.ReadLine();

		for (int a = 0; a < names.Length; a++)
		{
			if (names[a] == "Mike")
			{
				Console.WriteLine(names[a] + " " + userName);
			}
			else if (names[a] == "Joe")
			{
				Console.WriteLine(names[a] + " " + userName);
			}
			else if (names[a] == "John")
			{
				Console.WriteLine(names[a] + " " + userName);
			}
			else if (names[a] == "Jerry")
			{
				Console.WriteLine(names[a] + " " + userName);
			}

		}
		//Console.ReadLine();

// 2. created infinite loop by removing m++ from the for loop above, or
		//int b = 0;
		//while (b < 10)
		//{
		//	Console.WriteLine("2.create infinite loop  " + b);
		//	b--;
		//}
		//Console.ReadLine();

// Practice:  This is an attempt at an infinite loop
		//int b = 0;
		//while (b > 0)
		//{
		//	if (b >= 0)
		//	{
		//		Console.WriteLine("Value of b: {0}", b);
		//		b++;
		//	}
		//}
		//Console.ReadLine();

// Practice:  Was told this is not an infinite loop
		//while (true)
		//{
		//	Console.WriteLine(true);
		//	Console.ReadLine();
		//}


// 3. re-added m++ to fix infinite loop in #1, or fixed 2 above by changing increment from -- to ++
		int c = 0;
		while (c < 10)
		{
			Console.WriteLine("3.fix infinite loop  " + c);
			c++;
		}
		//Console.ReadLine();

// testing a loop
		//int c = 0;
		//while (c < 10)
		//{
		//	if (c > 0)
		//	{
		//		Console.WriteLine("Value of c: {0}", c);
		//		c++;
		//	}
		//}
		//Console.ReadLine();

// 4. Create a loop using < operator --- I did that in the for loop
		int d = 0;
		while (d < 10)
		{
			Console.WriteLine("4.use < operator in a loop  " + d);
			d++;
		}
		//Console.ReadLine();

// 5. Create loop using <=

		int e = 0;
		while (e < 10)
		{
		//for(;;)
		//{
			if (e <= 10)
			{
				Console.WriteLine("5. Use <= in a loop  ", e);
				//Value of e: {0}
				e++;
			}
			//else
			//break;
		}
		//Console.ReadLine();

// testing
		//int e = 0;
		//for (;;)
		//{
		//	if (e <= 7)
		//	{
		//		Console.WriteLine("Value of e: {0}", e);
		//		e++;
		//	}
		//	else
		//	break;
		//}

// testing
		//for (int e = 0; e < 50; e--)
		//{
		//	Console.WriteLine("value : {0}", e);
		//	Console.ReadLine();
		//}

// 6 - 8. List of strings, tell user's wrong, stop if right
		List<string> words = new List<string>() { "Mike", "Ninja", "Checkers" };
		//Console.Clear();
		Start:
		Console.Write("Choose a word - Mike, Ninja, or Checkers: ");
		string newWord = Console.ReadLine();
		bool isWord = true;
		while (isWord)
		{
			if (newWord == "Mike")
			{
				Console.WriteLine("Mike is " + isWord);  
				break;
			}
			else if (newWord == "Ninja")
			{
				Console.WriteLine(isWord);
				break;
			}
			else if (newWord == "Checkers")
			{
				Console.WriteLine(isWord);
				break;
			}
			else
			{
				Console.WriteLine("You typed wrong.  Please try again");  
				goto Start;
			}
			//Console.ReadLine();
			//return;
		}
		Console.ReadLine();

// 9 - 10. list of strings with 2 identical strings in the list
		List<string> fNames = new List<string>() { "Mike", "Mike", "Michael", "Joe"};
		//Console.Clear();
		startHere:
		Console.Write("Type Mike, Michael, or Joe:  ");
		string name = Console.ReadLine();
		bool isName = true;
		while (isName)
		{
			if (name == "Mike")
			{
				Console.WriteLine("Mike is " + isName);  
				break;
			}
			else if (name == "Michael")
			{
				Console.WriteLine(isName);
				break;
			}
			else if (name == "Joe")
			{
				Console.WriteLine("Joe is good.");
				break;
			}
			else
			{
				Console.WriteLine("You typed wrong.  Please try again");  
				goto startHere;
			}
			//Console.ReadLine();
			//return;
		}
		Console.ReadLine();




/* 11.  List with foreach, identical strings, message says whether or not string is new
 * Jordan said, for 11 one way is to make two lists, one of them empty (duplicates list).  
 * Iterate through the primary list and check if each element is in the duplicates list, 
 * if it isn't then add it, if it is then it means that it is a repeat value. .Contains will help with that.
 */


// not sure if this is exactly what you're looking for.  If I don't use breaks, it lists all dupes.
		List<string> names = new List<string>() { "Mike", "Mikey", "Michael" };
		List<string> dupeScores = new List<string>(); 

		foreach (string name in names)
		{
			if (name == "Mike")
			{
				Console.WriteLine("Mike is a dupe");
				break;
			}
			else if (name != "Mikey")
			{
				Console.WriteLine("Mikey is a dupe");
				break;
			}
			else if (name != "Michael")
			{
				Console.WriteLine("Michael is a dupe");
				break;
			}
			else
			{
				dupeScores.Add(name);
			}
		}
		Console.ReadLine();





// 11 practice
		//List<string> myNames = new List<string>() { "Mike", "Mike", "Mikey", "Michael" };
		//List<int> dupeNames = new List<int>();

		//foreach (string myName in myNames)
		//{
		//	if (!myNames.Contains(myName == "Mikey")
		//	{
		//		Console.WriteLine("Write {0}", myName);
		//	}

		//}
		//Console.ReadLine();


// 11 practice
		//string[] myNames = {"Mike", "Mike", "Mikey","Michael"};

		//var myList = new List<string>();
		//var duplicates = new List<string>();

		//foreach (var s in myNames)
		//{
		//   if (!myList.Contains(s))
		//      myList.Add(s);
		//   else
		//      duplicates.Add(s);
		//}

// show list without duplicates 
		//foreach (var s in myList)
		//   Console.WriteLine(s);

// show duplicates list
		//foreach (var s in duplicates)
		//   Console.WriteLine(s);

		//Console.ReadLine();


// 11. practice
		//List<string> myNames = new List<int>() { "Mike", "Mikey", "Michael" };
		//List<int> dupeNames = new List<int>(); // this creates a blank list, which can be done with lists, not arrays (you don't have to define how big a list is)
		//foreach (string name in myNames)
		//{
		//	if (name > 85)
		//	{
		//		passingScores.Add(score);
		//	}
		//}
		//Console.WriteLine(passingScores.Count); // arrays uses length, list uses count
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

	}
}
