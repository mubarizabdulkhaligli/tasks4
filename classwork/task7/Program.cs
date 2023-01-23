using System;

namespace task7
{
	class Program
	{

		//Task 7. Verilmis yazini verilmis indexe qeder kesib qaytaran metod


		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			int index = Convert.ToInt32(Console.ReadLine());

			string result = cutToIndex(word, index);
			Console.Write(result);
		}

		static string cutToIndex(string word, int index)
		{
			string str = "";

			for (int i = 0; i < index; i++)
			{
				if (index < word.Length)
				{
					str = str + word[i];
				}
				else
				{
					str = word;
				}
			}
			return str;
		}
	}
}
