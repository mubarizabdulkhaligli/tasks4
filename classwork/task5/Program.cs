using System;

namespace task5
{
	class Program
	{

		// Task 5. Verilmis yazida reqem olub-olmadigini tapan metod


		static void Main(string[] args)
		{
			string word = Console.ReadLine();

			var check = HasNumber(word);
			Console.WriteLine(check);
		}

		static bool HasNumber(string word)
		{

			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] >= 48 && word[i] <= 57)
				{
					return true;
				}
			}
			return false;
		}
	}
}
