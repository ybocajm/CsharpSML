using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSWITCH_WHILE
{
	class Program
	{
		static void Main(string[] args)
		{
// This is for the assignment on page 126.  I was initially going to use food, but I couldn't get it to work, so I'm sticking with what I know for now.
			Console.WriteLine("Guess a number?");
			int number = Convert.ToInt32(Console.ReadLine());
// STEP 2 WHILE LOOP EDIT:  For the WHILE LOOP, I created this variable
			bool guessing = false;

// STEP 2 WHILE LOOP EDIT:  This while loop is new and the whole switch statement will go into this while loop
			while (!guessing)
			{

				switch (number) // this begins a switch statement
				{
					case 1:
						Console.WriteLine("You guessed 1.  Snooze."); // means more or less if number = 1
// STEP 2b WHILE LOOP EDIT:  Copy PASTE this from above so each wrong guess becomes unique
// STEP 2b WHILE LOOP EDIT:  SINCE INT number is created above, it doesn't need to be created again, but the number is read in from user input
						Console.WriteLine("Guess a number?");
// I'm not 100% on why INT is removed.  The video didn't explain this, but to make it work, I have to do it.
						number = Convert.ToInt32(Console.ReadLine());
						break;  // it will keep going with the switch statement

// According to the quiz, the break tells the program to stop running the switch statement if the condition has been met at that point.
// That doesn't mean the program is complete, it's (in my interpretation) a pause, so this part of the program can complete, or has been run

					case 3:  // 2nd case - did they guess 3?
						Console.WriteLine("You guessed 3.  Snooze.");
// STEP 2b WHILE LOOP EDIT:  Copy PASTE this from above so each wrong guess becomes unique
						Console.WriteLine("Guess a number?");
						number = Convert.ToInt32(Console.ReadLine());
						break;
					case 5:
						Console.WriteLine("You guessed 5.  Snooze.");
// STEP 2b WHILE LOOP EDIT:  Copy PASTE this from above so each wrong guess becomes unique
						Console.WriteLine("Guess a number?");
						number = Convert.ToInt32(Console.ReadLine());
						break;
					case 2:
						Console.WriteLine("You guessed the number 2.  That is correct!");
// STEP 2a WHILE LOOP EDIT:  need this to prevent infinite looping, but other numbers are infinitely looping too.
						guessing = true;
						break;
					// but in case none of those were correct, you can throw in a default
					default:
						Console.WriteLine("Guess the news, you lose.");
// STEP 2b WHILE LOOP EDIT:  This needs to be added/edited (INT removed) for the default as well.
						Console.WriteLine("Guess a number?");
						number = Convert.ToInt32(Console.ReadLine());
						break;
				}

			}
			Console.Read();

// STEP 2 WHILE LOOP NOTE:  Running the program and guessing 2 yields the correct answer, but when I hit enter, it keeps outputting  that I'm correct.
// STEP 2a WHILE LOOP EDIT:  ADD guessing = true; to case 2 so it doesn't loop.

// The problem with a switch statement is that it only runs once.
// So you have to start the program and run it for each guess.  Not practical.


// What would be practical is to loop this so it runs over and over again until guessed correctly
// WHILE LOOP
// going to create a true/false boolean

// The problem with the while loop is if 2 is guessed on the first try, then while loop never runs.
// A DO loop ensures the loop will run at least once

		}
	}
}
