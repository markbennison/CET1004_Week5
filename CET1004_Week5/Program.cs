using static CET1004_Week5.Menus;

namespace CET1004_Week5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int menuOption;

			do
			{
				menuOption = Menus.GetMainMenuOption();

				switch (menuOption)
				{
					case 1:
						CreateBook();
						break;
					case 2:
						CreateLibray();
						break;
				}
			} while (menuOption > 0);

			void CreateBook()
			{
				Console.Clear();
				// Create a Book object
				Book book1 = new Book("C# Basics", "John Adams", 25.99, 3);
				// Show initial details
				Console.WriteLine("=== Original Book Info ===");
				book1.DisplayBookInfo();
				Console.WriteLine();
				// Change the price
				book1.SetPrice(19.99);
				// Show updated details
				Console.WriteLine("=== Updated Book Info ===");
				book1.DisplayBookInfo();
				// Access title with getter
				Console.WriteLine("\nBook Title Retrieved: " + book1.GetTitle());
				Console.ReadKey();
			}

			void CreateLibray()
			{
				Console.Clear();
				// Create a Library object
				Library london = new Library("Games Library", "London", 157);
				// Show initial details
				Console.WriteLine("=== Library 1 Info ===");
				london.DisplayLibraryInfo();
				Console.WriteLine();
				// Create a Library object
				Library sunderland = new Library("Tech Library", "Sunderland", 250);
				// Show initial details
				Console.WriteLine("=== Library 2 Info ===");
				sunderland.DisplayLibraryInfo();
				Console.WriteLine();
				Console.ReadKey();

			}
		}
	}
}