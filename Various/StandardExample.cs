using System;

namespace Various
{
	public class StandardExample
	{
		public string Property1 = "Im alive!";

		public StandardExample()
		{
			Console.WriteLine(Property1);
		}

		public string ReturnProperty1Value()
		{
			return Property1;
		}
	}
}

