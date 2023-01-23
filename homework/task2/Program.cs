using System;

namespace task2
{
	class Program
	{

		// Task 2. Verilmis string deyerindeki sozlerin sayini tapan metod


		static void Main(string[] args)
		{
			Console.WriteLine("Metni daxil edin: ");
			string text = Console.ReadLine();

			int wordsCount = FindCountOfWords(text);

			Console.WriteLine("Metndeki sozlerin sayi: "+wordsCount);
		}


		static int FindCountOfWords(string text)
		{
			int CountOfWord = 1;

			for (int i = 0; i < text.Length; i++)
			{
				if (text[i]==' ')
				{
					CountOfWord++;
				}
			}
			return CountOfWord;
		}
	}
}

