using System;

namespace task5
{
    class Program
    {

        //Task 5. Verilmis yazidaki ilk bosluq olmayan indexi qaytaran metod


        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int index = FindIndex(text);

            Console.WriteLine(index);
        }

        static int FindIndex (string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] !=' ')
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

