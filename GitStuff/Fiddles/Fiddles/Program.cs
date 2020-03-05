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