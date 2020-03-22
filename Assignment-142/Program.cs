using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_142
{
	class Program
	{
		static void Main(string[] args)
		{
// 1. Create a one-dimensional array of strings, take input, add to strings, print each on separate lines

		string[] names = { "Mike", "Joe", "John", "Jerry", "lkj;lkj" };
		Console.Write("Type a word:  ");
		string userName = Console.ReadLine();

		for (int a = 0; a < names.Length; a++)
		{
			Console.WriteLine(names[a] + " " + userName);
		}

	
// 2. created infinite loop by removing m++ from the for loop above, or
		int b = 0;
		while (b < 10)
		{
			Console.WriteLine("2.create infinite loop  " + b);
			b--;
			break; // I put this in here so that all portions of this assignment can be run.  Comment out break to see the infinite loop if need be.
		}


// 3. re-added m++ to fix infinite loop in #1, or fixed 2 above by changing increment from -- to ++
		int c = 0;
		while (c < 10)
		{
			Console.WriteLine("3.fix infinite loop  " + c);
			c++;
		}


// 4. Create a loop using < operator --- I did that in the for loop
		int d = 0;
		while (d < 10)
		{
			Console.WriteLine("4.use < operator in a loop  " + d);
			d++;
		}

// 5. Create loop using <=.  Jordan says use -1 in a for loop

		for (int e = 0; e <= names.Length -1; e++)
		while (e < 10)
		{
			Console.WriteLine("5. Use <= in a loop  " + e); // I'm not sure why this was , e.   I think Jordan had me do that, but it doesn't work.  
				                                            // When I change to +, it outputs the value for e
			e++;
		}
		Console.ReadLine();

/* 6 - 8. List of strings, tell user's wrong, stop if right
 * I was taking notes while Jordan was helping me, but I must have misunderstood. 
 * He said to output the index, but I also thought he said put a for loop in a while loop
 * that confused me
 * This is my feeble attempt so far and I've spun my wheels for an hour, so I'm checking in for a tip
 * I get that I need to fix the index part.  I know the output's wrong and such, but I'm just a bit confused and my brain is scrambled
 */
			List<string> words = new List<string>() { "Mike", "Ninja", "Checkers" };
			//Console.Clear();
			//Start:
			Console.Write("Choose a word - Mike, Ninja, or Checkers: ");
			string newWord = Console.ReadLine();
			bool isWord = false;
			// me:  bool isWord = true;
			while (!isWord)
			{
				for (int f = 0; f < names.Length; f++)
				{
					Console.WriteLine("what's going on?");
					// endless loop.  There's too much going on with this.  I probably need to take a step back in the morning and start over with this one.
				}
			}
			Console.ReadLine();

		}
	}
}
