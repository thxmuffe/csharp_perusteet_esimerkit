using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1_Paavon_Esimerkki.ClassExample.UserDefinedClass
{
	public class Example
	{
		public static void Example1() {
			var school1 = new School();
			var student1 = new Student(school1) {  };
			Console.WriteLine($"Student: FirstName='{student1.FirstName}' LastName='{student1.LastName}' Address='{student1.Address}'");
		}

		public static void LINQ_Example()
		{
			var school1 = new School();
			var student1 = new Student(school1) { };
			Console.WriteLine($"Student: FirstName='{student1.FirstName}' LastName='{student1.LastName}' Address='{student1.Address}'");
		}
	}
}
