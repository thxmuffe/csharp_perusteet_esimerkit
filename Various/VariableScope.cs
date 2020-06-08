using System;

public class VariableScope
{
	public int Example1()
	{
		var x = 1;

		if (x == 1)
		{
			var y = 0;
		}

		return x + y;
	}

	public int Example2()
	{
		var x = 3;
		return x;
	}
}
