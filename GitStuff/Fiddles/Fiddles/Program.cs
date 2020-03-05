using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		//List in C# is similar to an array, 
		//This is a dictionary that is of type 'string' and type 'List', the key is the 'string' and the value is a 'List" of type 'strings'
		//ex: "Penny" = idioms[0].key
		Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
		idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
		idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
		idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
		idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
		idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
		idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
		idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
		idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
		idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
		idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });
		idioms.Add("Doom", new List<string> { "What's", "in", "the", "case?" });


		//This is how you access and loop through a single item in the dictionary 'idioms' 
		//will pirint every word(value) in list with key of "Moon"
		foreach (string value in idioms["Moon"])
		{
			Console.WriteLine(value);
		}


		//this is to put a space between the words so the sentence is readable
		string emptySpace = " ";

		//Loop through the Dictionary with foreach and use .Join() to combine all the words in the 
		foreach (string key in idioms.Keys)

		{
			string results = String.Join(emptySpace, idioms[key]);
			Console.WriteLine($"{key}: {results} ");
		}
	}
}






using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		//Create a sorted list and add some keyValuePairs
		SortedList<int, string> sortedList1 = new SortedList<int, string>();
		sortedList1.Add(3, "Three");
		sortedList1.Add(4, "Four");
		sortedList1.Add(1, "One");
		sortedList1.Add(5, "Five");
		sortedList1.Add(2, "Two");

		//How to count how many keyValuePairs are in a sorted list
		Console.WriteLine("sortedList1 has " + sortedList1.Count + " items in the list");
		//for extra credit loop over the list and print the SortedList to the Console
		foreach (KeyValuePair<int, string> item in sortedList1)
		{
			Console.WriteLine(item.Key + "" + item.Value);
		}


		SortedList<string, int> sortedList2 = new SortedList<string, int>();
		sortedList2.Add("one", 1);
		sortedList2.Add("two", 2);
		sortedList2.Add("three", 3);
		sortedList2.Add("four", 4);
		sortedList2.Add("five", 5);
		// Compile time error: cannot convert from <null> to <int>
		//sortedList2.Add("Five", null);

		//How to count how many items are in a sorted list2
		Console.WriteLine("sortedList2 has " + sortedList2.Count + " items in the list");

		//Loop over sortedList2 with a regular 'for loop', see sortedList3 below for a 'foreach' loop, you can use either one to loop over sortedList1 for extra credit
		//Hint: copy and paste this above and change sortedList2 -> sortedList1
		for (int i = 0; i < sortedList2.Count; i++)
		{
			Console.WriteLine("key: {0}, value: {1}", sortedList2.Keys[i], sortedList2.Values[i]);
		}






		//the ? after int lets us add in null values, without the ? it will say "cannot convert from <null> to <int>" and will not work
		//creates a sorted list with keyValuePairs
		SortedList<double, int?> sortedList3 = new SortedList<double, int?>()
		{
				{1.2, null},
				{3.6, 400},
				{7.1, 701}
		};
		//adds more keyValuePairs with .Add()
		sortedList3.Add(1.5, 100);
		sortedList3.Add(3.5, 200);
		sortedList3.Add(2.4, 300);
		sortedList3.Add(2.3, null);
		sortedList3.Add(1.1, null);



		//How to count how many items are in a sorted list 3
		Console.WriteLine("sortedList3 has " + sortedList3.Count + " items in the list");

		//How to loop over the sortedList3
		foreach (KeyValuePair<double, int?> kvp in sortedList3)
		{
			Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

		}

	}
}







using System;
using System.Collections.Generic;
using System.Collections.Specialized;
					
public class Program
{
	public static void Main()
	{

		// Make a new empty List, we will be creating a List of Dictionary's
		List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();



		//create an empty Dictionary named 'excited' then use .Add to insert some key/value pairs, we will add this to the empty list called 'dictionaryOfWords'
		Dictionary<string, string> excited = new Dictionary<string, string>();

		excited.Add("word", "excited");
		excited.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
		excited.Add("part of speech", "adjective");
		excited.Add("example sentence", "I am excited to learn C#!");
		excited.Add("CACAPOOPOOPEEPEE", "I'm so funny.");

		dictionaryOfWords.Add(excited);



		Dictionary<string, string> bitcoin = new Dictionary<string, string>();

		bitcoin.Add("word", "bitcoin");
		bitcoin.Add("definition", "majik internet monies");
		bitcoin.Add("part of speech", "noun");
		bitcoin.Add("example sentence", "I am excited to stack bitcoin sats");



		dictionaryOfWords.Add(bitcoin);

		Dictionary<string, string> computers = new Dictionary<string, string>();

		computers.Add("word", "computers");
		computers.Add("definition", "boxes for data");
		computers.Add("part of speech", "noun");
		computers.Add("example sentence", "I am excited to computer");



		dictionaryOfWords.Add(computers);

		/*
			You want to track the following about each word:
				word, definition, part of speech, example sentence

			Example of one dictionary in the list:
		   {
				"word": "excited",
				"definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
				"part of speech": "adjective",
				"example sentence": "I am excited to learn C#!"
			}
		*/

		// Create dictionary to represent a few word
		// Dictionary<string, string> excitedWord = new Dictionary<string, string>();

		// Add each of the 4 bits of data about the word to the Dictionary
		// excitedWord.Add();

		// Add Dictionary to your `dictionaryOfWords` list


		// create another Dictionary and add that to the list


		/*
			Iterate your list of dictionaries and output the data

			Example output for one word in the list of dictionaries:
				word: excited
				definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
				part of speech: adjective
				example sentence: I am excited to learn C#!
		*/

		// Iterate the List of Dictionaries with a foreach loop inside another foreach loop
		//a foreach loop inside another foreach loop
		foreach (Dictionary<string, string> list in dictionaryOfWords)
		{

			Console.WriteLine("------");
			foreach (KeyValuePair<string, string> word in list)
			{

				Console.WriteLine($"{word.Key}: {word.Value} ");
			}
		}


	}
}






using System;
using System.Collections.Generic;			

public class Program
{
	public static void Main()
	{
		///////////////////////////////////////////////////
		////////////Types of Variables in C#///////////////
		///////////////////////////////////////////////////

		//this is how you definie or instantiate a variable(s)
		//hint: you have to define the variable above the code that uses that variable
		//hint: always put a ; after defining a variable or writting an array, list, if-statement, or for-loop, and after every Console.WriteLine put a semi-colon

		//defining(instantiate) a variable of type int
		int gradeOnTest1 = 80;
		int gradeOnTest2 = 100;
		//you can add variables together, even string but that is called concatination, and i will show that further down
		//below should print the average of the 2 test grades
		Console.WriteLine((gradeOnTest1 + gradeOnTest2) / 2 + " is the average test score");

		//string(words or letters and always uses " " when defining a string variable)
		string instructorFirstName = "Russell";
		string instructorLastName = "Miller";
		//this is how you add two strings together
		Console.WriteLine(instructorFirstName + instructorFirstName);// if you check the output it is -- RussellMiller with no space
		Console.WriteLine(instructorFirstName + " " + instructorLastName);//this is why we learned $"{string interpolation}" see below
		Console.WriteLine($"The instructors name is {instructorFirstName} {instructorLastName}");

		//double is like int but you can have 2 decimal spots like below
		double GPA = 3.55;

		//char is just a single letter(character), can be upper or lower case
		char courseFinalGrade = 'B';

		Console.WriteLine(courseFinalGrade);



		/////////////////////////////////////////////
		////////////Arrays in C#/////////////////////
		////////////////////////////////////////////

		//you can also define(instantiate) a list or array, think of an array or <List> as a regular "numbered list" except its sideways and seperated by commas, and the first thing on the list is at spot 0 instead of 1 and we call this the index, the second item in every array is at index 1, the third item is at index 2, and so on...


		//array, you have to tell it what the items in the array are made up of: numners(int), letters(char), words(string), etc...


		//array of whole numbers
		int[] allQuizGrades = new int[] { 99, 100, 84, 77, 7, 91, 13, 86 };

		//array of numners that have 2 decimal places
		double[] gpaBySemester = new double[] { 4.0, 3.59, 3.55, 3.84 };

		//array of strings(words)
		string[] studentNames = new string[] { "Bobby", "Sarah", "Jessica", "John" };



		//////////////////////////////////////////////
		////////////If Statements in C#///////////////
		//////////////////////////////////////////////


		//this is a simple if-else statemnt checking to see if the test grade is 90 or above
		if (gradeOnTest1 >= 90)
		{
			Console.WriteLine($"you scored {gradeOnTest1} on the test which is an A");

		}
		else { Console.WriteLine("you didn't score an A"); }



		//Another if statement but with the == to see if the two variables are the same

		if (instructorFirstName == "Russell")
		{
			Console.WriteLine($"you have the best instructor and his name is {instructorFirstName} and he is super humble");
		}


		//////////////////////////////////////////////////////
		////////////For and Foreach Loops in C#///////////////
		/////////////////////////////////////////////////////

		//for loops are for looping over a list or array, or checking each item on the list top preform an operation or check with if statement, etc. You can put whatever logic you like between the two {    }as you see below in the first example            

		//this is a simple for loop that prints the index number to the console, its not printing any of the items on the list, just the index, or numbers of the list



		// it basically says to the computer, 
		// -start at spot 0 with ->(int k = 0)
		// -tells the computer to print the index its currently on --> Console.WriteLine(k)
		// -tell it how long the list is, here its 999 spots (k<=999), how many times to loop over the array
		// -says to count every single spot (k++) means k=k+1,
		for (int k = 0; k <= 15; k++)
		{
			Console.WriteLine(k);
		}
		// so the first loop k = 0, so k=0+1 simplifies to k=1
		// second loop k =1, so k=1+1 which simplifies to k=2
		//it continues looping until it hits the end of the list or until it returns a false(more on that later)

		//dont worry too much about for-loops, but understand what they are essentially doing, because we will use built-in functions that use for loops "behind the scenes" but simplify the process and amount of code to write. For-loop  principles apply to many useful built-in functions(you will use some in chapter 4 and throughout the rest of the course)



		/////////////////////////////////////////////////
		////////////Lists and Foreach Loops in C#///////
		//////////////////////////////////////////////

		//Very similar to array's and for-loops, but these are easier and have more functionality, we will no longer use arrays after this chapter
		//this is how you instantiate a List, notice you have to still tell it what the list items are made up of, here its words(strings)
		List<string> students = new List<string>()
			 {
				"Megan", "Damon", "Chase", "Tekisha",
				"Castle", "Mark", "Keith", "Adam",
				"Patrick", "Hannah", "Mike"
			};


		///// 1) hard way to iterate through an array
		Console.WriteLine(students[0]);
		Console.WriteLine(students[1]);
		Console.WriteLine(students[2]);
		Console.WriteLine(students[3]);
		Console.WriteLine(students[4]);
		Console.WriteLine(students[5]);
		Console.WriteLine(students[6]);
		Console.WriteLine(students[7]);
		Console.WriteLine(students[8]);
		Console.WriteLine(students[9]);
		Console.WriteLine(students[10]);

		////// 2) easier way to iterate through an array is with a foreach, which is like for-loop but much easier and it detects the length of the list or array automatically, there are many built in function within C# .NET Core that are very useful.
		foreach (string name in students)
		{
			Console.WriteLine(name);
		}

		///// 3) easiest way to iterate over items in a list, this is the easiest of the 3
		students.ForEach(stu => Console.WriteLine(stu));

		//how to count how many items are in a list, you might get squiggly red line-> press lightbulb and chose first option, using linq..
		Console.WriteLine(students.Count);
		//you can add a number and a variable name together, you can divide 1/2 , remainder(modulus ) % , addition + and subtraction - , and many more with custom built-in functions and lib's you can download 
		Console.WriteLine(students.Count + 1);









	}

}






using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		/*
				  Create a dictionary with key value pairs to
				  represent words (key) and its definition (value)
		  */
		Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
				{"bitcoin", "magic internet money"},
				{"shitcoins", "non magic scam money"},
				{"satoshi", "me muhahaha  ;)"},
				{"Austin", "Big Boy. :)"}
			};

		// Add several more words and their definitions
		wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
		wordsAndDefinitions.Add("C#", "An object oriented programming language(OOP");
		wordsAndDefinitions.Add("4 Pillars of OOP", "abstraction, encapsulation, inheritance, and polymorphism");
		wordsAndDefinitions.Add("Blender", "The greatest 3D Program");
		wordsAndDefinitions.Add("C4D", "The worst 3D program");
		wordsAndDefinitions.Add("Maya", "Also the worst 3d Program");


		/*
			Use square bracket lookup to get the definition two
			words and output them to the console
		*/

		// you can use nameOfDictionary[key] to search your dictionary and grab the value of the key, here 'bitcoin' is the key and 'magic internet money is the value'
		//first make a title so you can easily keep track of values you are printing to the console.
		Console.WriteLine("Returns the value(defintion) of the key specified, ex: nameOfDictionary[key]");
		Console.WriteLine(wordsAndDefinitions["bitcoin"]);
		Console.WriteLine(wordsAndDefinitions["satoshi"]);
		Console.WriteLine(wordsAndDefinitions["Blender"]);
		/*
			Loop over dictionary to get the following output:
				The definition of [WORD] is [DEFINITION]
				The definition of [WORD] is [DEFINITION]
				The definition of [WORD] is [DEFINITION]
		*/
		foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
		{
			Console.WriteLine($" -{word.Key}- Definition: {word.Value}");
		}

	}
}