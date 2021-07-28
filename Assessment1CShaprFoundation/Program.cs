using System;

namespace Assessment1CSharpFoundation
{
	class Program
	{
		static void Main(string[] args)
		{
			bool goAgain = true;
			while (goAgain)
			{
				Console.WriteLine("Rectangle or Triangle (1/2)?:");
				string choice = Console.ReadLine();

				// rectangle
				if(choice == "1")
				{
					Console.WriteLine("Height: ");
					int height = int.Parse(Console.ReadLine());
					Console.WriteLine("Width: ");
					int width = int.Parse(Console.ReadLine());
					
					//the outer loop controls how many rows are written
					for(int i = 0; i < height; i++)
					{
						// this loop writes the correct number of stars for each row
						for(int j = 0; j < width; j++)
						{
							Console.Write("*");
						}
						// This makes a new line after the row is written
						Console.WriteLine();
					}

				}
				//triangles
				if (choice == "2")
				{
					Console.WriteLine("Height: ");
					int height = int.Parse(Console.ReadLine());
					Console.WriteLine("Right or left aligned? ");
					string alignment = Console.ReadLine();

					if(alignment == "left")
					{
						// create a string to hold the asterisk row
						string row = "";
						for(int i = 0; i < height; i++)
						{	
							// each loop, add an asterisk to the row
							row += "*";
							Console.WriteLine(row);			
						}
					}

					if(alignment == "right")
					{
						for (int i = 0; i < height; i++)
						{
							// this will print out the number of spaces equal to the height minus one
							for (int j = 0; j < height - i; j++)
							{
								Console.Write(" ");
							}
							// and then the number of asterisks equal to i
							for (int k = 0; k <= i; k++)
							{
								Console.Write("*");
							}
							// and then a line break to start the next row
							Console.WriteLine("");
						}
						
					}
				}
				Console.WriteLine("Would you like to draw another shape (y/n)?");
				string again = Console.ReadLine();
				while(again != "y" && again != "n")
				{
					Console.WriteLine("Please enter y or n: ");
					again = Console.ReadLine();

				}
				if(again == "n")
				{
					goAgain = false;
					Console.WriteLine("Bye!");
				}
			}
		}
	}
}
