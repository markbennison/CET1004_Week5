using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CET1004_Week5
{
	internal class Library
	{
		string name;
		string city;
		int bookQuantity;

		public Library(string name, string city, int bookQuantity) 
		{
			this.name = name;
			this.city = city;
			this.bookQuantity = bookQuantity;

		}

		public void SetName(string name)
		{
			this.name = name;

		}

		public void DisplayLibraryInfo()
		{
			Console.WriteLine("Welcome to {0} ({1})!", name, city);
			Console.WriteLine("We have {0} books on our shelves.", bookQuantity);

		}

	}
}
