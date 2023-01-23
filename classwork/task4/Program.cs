using System;

namespace task4
{
	class Program
	{

		//Task 4. Verilmis charin reqem olub olmadigini tapan metod


		static void Main(string[] args)
		{
			char cr = Convert.ToChar(Console.ReadLine());

			var result = isNumber(cr);

			Console.WriteLine(result);
		}

		static bool isNumber(char cr)
		{
			if (cr >= 48 && cr <= 57)
			{
				return true;
			}
				return false;
		}

	}
}
