using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		string yourString = "The value is: 99 @086.78";
		string newString = "";	// MUST set the Regex result to a variable for it to take effect
		newString = Regex.Replace(yourString, @"\s+", ""); //Replaces all(+) space characters (\s) with empty("")
		Console.WriteLine(newString);
		// Output: Thevalueis:99086.78
	}
}