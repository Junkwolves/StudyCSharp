using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCurrency_Converter \n");

            Console.WriteLine("\nEnter the amount in euros:");

            double Euro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n" + Euro + " Euro to ... \n" + "\n 1 - Dollar");

            Console.WriteLine("\n 2 - Hryvnia");

            Console.WriteLine("\n 3 - Ruble");

            Console.WriteLine("\n 4 - All");

            Console.WriteLine("");

        Choice:

            double choice = Convert.ToDouble(Console.ReadLine());

            double Convert_res = 0;

            if (choice == 1)
            {
                Convert_res = Euro * 1.12994;

                Console.WriteLine("\n" + Euro + " Euro  = " + Convert_res + " Dollar");
            }
            else if (choice == 2)
            {
                Convert_res = Euro * 30.6370;

                Console.WriteLine("\n" + Euro + " Euro  = " + Convert_res + " Hryvnia");
            }
            else if (choice == 3)
            {
                Convert_res = Euro * 74.0678;

                Console.WriteLine("\n" + Euro + " Euro  = " + Convert_res + " Ruble");
            }
            else if (choice == 4)
            {
                Convert_res = Euro * 1.12994;

                Console.WriteLine("\n" + Euro + " Euro  = " + Convert_res + " Dollar");

                Console.WriteLine("\n -------------------------------------------------- ");

                Convert_res = Euro * 30.6370;

                Console.WriteLine("\n" + Euro + " Euro  = " + Convert_res + " Hryvnia");
                Console.WriteLine("\n -------------------------------------------------- ");

                Convert_res = Euro * 74.0678;

                Console.WriteLine("\n" + Euro + " Euro  = " + Convert_res + " Ruble \n");
            }
            else
            {
                Console.WriteLine(" [1 - 4]");
                goto Choice;
            }

        }
    }
}