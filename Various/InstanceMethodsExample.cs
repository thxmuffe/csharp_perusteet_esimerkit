using System;

public class InstanceMethodExample
{
	// absence of static-keyword makes this an instance method (default)
	public void CallInstance()
	{
		Console.WriteLine("Instance!");
	}

	// static keyword makes this a class-method
	public static void CallClass()
	{
		Console.WriteLine("Classy!");
	}
}
