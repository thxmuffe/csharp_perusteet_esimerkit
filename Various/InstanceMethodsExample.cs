using System;

public class Dog
{
	public string Name, PreviousName;
	public bool Rescue;

	public static string Kingdom = "Animal";

	// absence of static-keyword makes this an instance method (default)
	public void Who()
	{
		Console.WriteLine("I am " + Name);
		Console.WriteLine("and I used to be called " + PreviousName);

		// extra...
		Console.WriteLine("and it is " + Rescue + " i was a rescue");
	}

	// static keyword makes this a class-method
	public static void What()
	{
		Console.WriteLine("Im a Dog");
		Console.WriteLine("... and I have a Name (i have property called 'Name')");
		Console.WriteLine("... and all of us belong to " + Kingdom + " kingdom");
	}
}
