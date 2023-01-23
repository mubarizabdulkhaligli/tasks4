using System;

namespace task6
{
	class Program
	{

		//Task 6. Verilmis yazini solunda bosluq olmayan veziyyetde qaytaran metod


		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			string NewText = DeleteLeftEmpty(text);

			Console.WriteLine(NewText);
		}


		static string DeleteLeftEmpty(string text)
		{
			string newText = "";

			for (int i = 0; i < text.Length;i++)
			{
				if (text[i]!=' ')
				{
					newText = newText + text[i];
				}
			}
			return newText;
		}
	}
}

