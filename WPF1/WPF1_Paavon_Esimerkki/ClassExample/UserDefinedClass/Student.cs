using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1_Paavon_Esimerkki.ClassExample.UserDefinedClass
{
	class Student
	{
		public Address Address;
		public string FirstName, LastName;

		// Private property (not visible to caller)
		List<School> EnrolledIn;

		// Constructor depanding the School object as parameter
		public Student(School enrolledIn)
		{
			EnrolledIn = new List<School> { enrolledIn };
		}

		// Add a school to student
		public void AddTo(School school) { EnrolledIn.Add(school); }

	}
}
