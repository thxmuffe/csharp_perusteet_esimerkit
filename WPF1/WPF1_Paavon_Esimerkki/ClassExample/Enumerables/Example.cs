using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1_Paavon_Esimerkki.ClassExample.Enumerables
{
	class Example
	{
		enum KitchenStuff { Glass, Table, Chair, Plate, Fork, Knife }

		void ExplainListDifferences()
		{

			// Array [] on fixed size enumerable, jonka jokainen alkio on numeroitu 0, ..... n?
			var x = new[] { 1111, 0, 555, 33 };
			Console.WriteLine("First alkio on = " + x[0]);
			Console.WriteLine("Last alkio on = " + x[3]);

			int xx;

			// Listaa List<jokutyyppi> on kivempi käyttää
			var y = new List<int> { 1, 2, 3, 4 };
			Console.WriteLine("First alkio on = " + y[0]);  // 1
			Console.WriteLine("Last alkio on = " + y[3]);   // 4
			Console.WriteLine("First alkio on = " + y.First()); // 1
			Console.WriteLine("Last alkio on = " + y.Last());   // 4

			
			y.Add(666); // Lisätään loppuun 666
			Console.WriteLine("Last alkio on = " + y.Last()); // Ja nyt Last = 666

			// Entäpä toinen alkio?
			Console.WriteLine("Toinen alkio on = " + y.Skip(1).First()); // 


			// Voidaan tehdä listasta array ja arraysta lista näin:
			var listana = x.ToList();
			var arrayna = y.ToArray();

			bool jimmy = true;
			var jimmyStr = jimmy.ToString();

			var stuff1 = KitchenStuff.Chair;
			var stuff2 = KitchenStuff.Glass;

		}

		void ToinenMetodi() { }

	}
}
