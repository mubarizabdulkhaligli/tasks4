using System;

namespace task3
{
	class Program
	{

		//Task 3. Verilmis ededler siyahisinda icinde yalniz musbet ededler qalan yeni bir array duzelden metod


		static void Main(string[] args)
		{
			int[] nums = { 1, 8, 9, -5, -10 };

			string PositiveNumbers = ChoosePositiveNums(nums);

			Console.WriteLine(PositiveNumbers);
		}

		static string ChoosePositiveNums(int[] nums)
		{
			string PositiveNumbersArray = "";

			for (int i = 0; i <nums.Length; i++)
			{
				if (nums[i]>0)
				{
					PositiveNumbersArray = PositiveNumbersArray + nums[i] + "," + " ";
				}
			}
			return PositiveNumbersArray;
			
		}

	}
}

