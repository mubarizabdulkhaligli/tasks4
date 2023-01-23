using System;

namespace task6
{
	class Program
	{

		//Task 6. Verilmis yazinin icersinde verilmis charin indexini tapan metod


		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			char cr = Convert.ToChar(Console.ReadLine());

			int index = FindIndex(word, cr);
			Console.WriteLine(index);
		}

		static int FindIndex(string word, char cr)
		{
			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] == cr)
				{
					return i;
				}
			}
			return -1;
		}
	}
}