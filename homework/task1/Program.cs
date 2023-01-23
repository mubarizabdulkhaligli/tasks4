using System;

namespace task01
{
	class Program
	{


		// Task 1. Verilmis string deyerindeki ilk sozu tapan metod


		static void Main(string[] args)
		{
			Console.WriteLine("Metni daxil edin: ");

			string text = Console.ReadLine();

			string firstWord = FindFirstWord(text);

			Console.WriteLine("ilk soz: " + firstWord);
		}

		static string FindFirstWord(string text)
		{
			string firstWord = "";

			for (int i = 0; i < text.Length;i++)
			{
				if (text[i]!=' ')
				{
					firstWord = firstWord + text[i];
				}
				else
				{
					do
					{
						firstWord = firstWord + text[i];
					} while (text[i]!=' ');
					break;
				}
			}
			return firstWord;

		}

	}
}


