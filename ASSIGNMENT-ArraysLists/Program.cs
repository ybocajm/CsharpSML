using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
   /* 
    * Assignment:136 Arrays and Lists
    */

// PART Ia:  Create a 1-dimensional Array of STRINGS.

   /*
    * Take user input, convert it, assign it to a variable, and use that variable as the index.
    * Console.WriteLine(numArray[integerSelected]);
    * 
    * This is no different than 
    * Console.WriteLine(numArray[3]);
    * except that it allows for a variable rather than hard coding in 3 every time it is run.
    */

        string[] nameArray = new string[3];
        nameArray[0] = "Joe";
        nameArray[1] = "John";
        nameArray[2] = "Jerry";
        ////bool isGuessed = false;


// PART Ib:  Have user select one and display it

        Console.Write("Part 1 ---> Select 0, 1, or 2:  ");
        string userChoice = Console.ReadLine();
        int yourChoice = Convert.ToInt32(userChoice);
        Console.WriteLine(nameArray[yourChoice]);
        ////Console.ReadLine();

// Part 2:  Select array and display index
        Console.Write("Part 2 ---> Select 0, 1, or 2:  ");
        string userChoice2 = Console.ReadLine();
        int yourChoice2 = Convert.ToInt32(userChoice2);
        Console.WriteLine("Your choice is nameArray[" + yourChoice2 + "]");
        //Console.WriteLine(nameArray[2]);
        Console.ReadLine();

// Part 3:  Add message for invalid choice (index doesn't exist)

        Console.Write("Part 3 ---> Select 0, 1, or 2:  ");
        string userChoice3 = Console.ReadLine();
        int yourChoice3 = Convert.ToInt32(userChoice3);

        if (yourChoice3 == 0)
        {
            Console.WriteLine("Your choice is nameArray[" + yourChoice3 + "]");
        }
        else if (yourChoice3 == 1)
        {
            Console.WriteLine("Your choice is nameArray[" + yourChoice3 + "]");
        }
        else if (yourChoice3 == 2)
        {
            Console.WriteLine("Your choice is nameArray[" + yourChoice3 + "]");
        }
        else
        {
            Console.WriteLine("That is an invalid choice, please try again");
        }
        Console.ReadLine();


        //Console.WriteLine("What is your name?");
        //string name = Console.ReadLine();
        //Console.WriteLine(name);
        //Console.ReadLine();

        //List<int> intList = new List<int>();
        //intList.Add(4); // that adds an integer to this list
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.WriteLine(intList[1]);
        //Console.ReadLine();

/* 
 * Lists are one of the more common features in C#
 * There's a lot of different methods
 */

        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Mike");
        intList.Add("Ninja");

        Console.Write("Part 4 ---> Pick 0, 1, or 2:  ");
        string userInput = Console.ReadLine();
        int pick = Convert.ToInt32(userInput);
        Console.WriteLine(intList[pick]);
        Console.ReadLine();


        /* 
         * An ARRAY is a way to hold a group of variables.  To declare, use square brackets, but also have to give a type of variables.
         * An example would be a group of integers.
         * This is an integer array called numArray:  
         */

        //int[] numArray;


        /*
         * To actually create an array, you have to instantiate it, because array's are the C# construct called objects.
         * So you have to create a new object of it.
         */


        //int[] numArray = new int[];


        /*
         * C# is expecting data within the brackets for the assigned part, thus new int[];  The specific message (if you hover over it) says
         * Array creation must have array size or array initializer
         * Jesse's saying you have to define the length before getting started.  How many items.  How many variables.
         * Jesse will use 5...
         */

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        // To prove something was actually added to the array, you can write to console.


        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();


        /* 
         * So that is how you initialize an array.  
         * You create a new instance - of an array - called an object.
         * Then print to console.
         * 
         * Of course there's an easier way.  If you know the numbers right off the bat, not going to put in a length.
         * 
         */

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        //Console.WriteLine(numArray1[3]);
        //Console.ReadLine();

        /*
         * Notice WriteLine has numArray1 and also 3 is the 4th number - as above array begins with 0 in the first slot.
         * The good part about this last array is it can be added to without changing a length value.  Thus C# is a bit intuitive in that regard.
         * 
         * Wow, wadda ya know.  So after all that there's an EVEN EASIER WAY. 
         * 
         * In the following example, you don't have to say you're creating a new integer array, C# figures it out.  Great, so what a waste of time.
         * 
         */

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //Console.WriteLine(numArray2[0]);
        //Console.ReadLine();

        /*
         * Now what if you want to change one of the values in the array?
         */

        //numArray2[5] = 650;
        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}
