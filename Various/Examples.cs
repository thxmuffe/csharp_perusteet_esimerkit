using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Various
{
	class Examples
	{
		void Test()
		{
			(new Dog()).Who();

			Dog.What();
		}

		void LINQ_Example()
		{
			var animals = new List<object> { new Dog(), new Dog(), new Cat() };

			var firstAnimal = animals.First();

			animals.Any(); // Tells us if list is empty or has items in it

			// where() is basic building block of LINQ
			var cats = animals.Where(a => a.GetType() == typeof(Cat));

			var filterCats = animals.Where(a => cats.Contains(a));

			var rescue_dogs = animals
				.Except(cats)
				.Where(a => ((Dog)a).Rescue);

		}
	}
}
