using System;

public class VariableScope
{
	public int Example1()
	{
		var z = ExampleCall();

		var x = 1;

		if (x == 1)
		{
			var y = 0;
		}

		//return x + y;

		return 0;
	}

	public int ExampleCall() // SISÄÄN
	{
		var x = 2;
		return x; // ULOS
	}

}
