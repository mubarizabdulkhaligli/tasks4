using System;

namespace task1
{
    class Program
    {

        //Task 1. Verilmis adlar siyahisinda verilmis adin olub-olmaidigini tapan metod


        static void Main(string[] args)
        {
            string[] names = { "Ali", "Orxan", "Vusal" };
            string name = "Ali";

            var result = FindName(names, name);
            Console.WriteLine(result);
        }

        static bool FindName(string[] names, string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
