using System;

namespace task3
{
	class Program
	{

		//Task 3. Verilmis ededler siyahisinda verilmis ededler siyahisindan hansisa ededin olub-olmadigini tapan metod


		static void Main(string[] args)
		{
			int[] array1 = { 1, 2, 3, 4, 5 };
			int[] array2 = { 7, 8, 5, 78 };

			var result = HasNumber(array1, array2);
			Console.WriteLine(result);
		}

		static bool HasNumber(int[] array1, int[] array2)
		{
			for (int i = 0; i < array1.Length; i++)
			{
				for (int j = 0; j < array2.Length; j++)
				{
					if (array1[i] == array2[j])
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}