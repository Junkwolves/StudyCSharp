using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Average of Two Numbers" + "\nEnter the first number: ");

            double First_Number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the second number: ");

            double Second_Number = Convert.ToDouble(Console.ReadLine());

            double Average = (First_Number + Second_Number) / 2;

            Console.WriteLine("\nAverage: " + Average);

        }
    }
}