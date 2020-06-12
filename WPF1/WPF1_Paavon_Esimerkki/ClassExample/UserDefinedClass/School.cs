using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1_Paavon_Esimerkki.ClassExample.UserDefinedClass
{
	// Luokan nimeltä "School" kategoria on luokka
	// Koulu on luokka nimeltä koulu
	class School
	{
		// Object property with no accessor
		public string SchoolName = "Business College Helsinki"; // default value

		// Object property with accessor (equal to previous, no real difference)
		public Address Address { get; set; }
		
		// private list of students (initially emtpy)		
		List<Student> Students = new List<Student>();

		// NumberOfStudents is actually a method, but looks like an attribute
		// (there is really no visible difference between method, object and attribute)
		public int NumberOfStudents => Students.Count;

		// A simple method which clears the list of students
		public void RemoveAllStudents()
		{
			Students.Clear();
		}

		// Renames the school
		// Rename could be done through the property accessor directly
		public void Rename(string schoolName)
		{
			SchoolName = schoolName;
		}

		// Adds a student to a school
		public void Enroll(Student student)
		{
			Students.Add(student);
		}
	}
}
