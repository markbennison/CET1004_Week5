using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CET1004_Week5
{
	internal class Book
	{
		string sTitle;
		string sAuthor;
		double dPrice;
		int iQuantity;

		public Book()
		{
			sTitle = "";
			sAuthor = "";
			dPrice = 0;
			iQuantity = 0;
		}
		public Book(string pbTitle, string pbAuthor, double pbPrice, int piQuantity)
		{
			sTitle = pbTitle;
			sAuthor = pbAuthor;
			dPrice = pbPrice;
			iQuantity = piQuantity;
		}

		public void DisplayBookInfo()
		{
			Console.WriteLine("Book Title: " + sTitle);
			Console.WriteLine("Author: " + sAuthor);
			Console.WriteLine("Price: £" + dPrice);
			Console.WriteLine("Available Quantity: " + iQuantity);
		}

		public string GetTitle()
		{
			return sTitle;
		}

		public void SetPrice(double pbPrice)
		{
			dPrice = pbPrice;
		}

	}
}
