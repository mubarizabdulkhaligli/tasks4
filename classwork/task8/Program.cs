using System;

namespace task8
{
    class Program
    {

        // Task 8. Daxil edilen e-mailde @ simvolu yoxdursa yeniden daxil etmeyimizi isteyen kod


        static void Main(string[] args)
        {
            bool hasAt = false;
            do
            {
                Console.WriteLine("E-maili daxil edin: ");
                string email = Console.ReadLine();

                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i]=='@')
                    {
                        hasAt = true;
                        break;
                    }
                }

            } while (hasAt==false);
        }
    }
}

