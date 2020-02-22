using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_strings
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ASSIGNMENT:131\n");

// PART I
			string name = "mike";
			string name2 = "michael";
			string name3 = "mikey";
			Console.WriteLine("concatenate: " + name + name2 + name3);
			Console.WriteLine();

// PART II
			name = name.ToUpper();
			Console.WriteLine("change name to all upper case: " + name);
			Console.WriteLine();


// PART III
			StringBuilder sb = new StringBuilder();
			sb.Append("StringBuilder:  My name is Mike \nI recently got a membership to planet fitness \nMy Father always had chicken legs, \nso I'm doing more to see that I don't have chicken legs. \nAt my last trip to the gym I was able to leg press 200 pounds.  \nIn due time, I'll double that.");
			Console.WriteLine(sb);

			Console.ReadLine();
		}
	}
}
