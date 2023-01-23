using System;

namespace task2
{
    class Program
    {

        //Task 2. Verilmis ededler siyahisinda verilmis ededin olub-olmaidigini tapan metod


        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int number = 9;

            var result = HasNum(numbers, number);

            Console.WriteLine(result);
        }

        static bool HasNum(int[] numbers, int number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
