using System;

namespace Addition_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Addition_Multiplication" + "\nEnter the first number: ");

            double First_Number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the second number: ");

            double Second_Number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the third number: ");

            double Third_Number = Convert.ToDouble(Console.ReadLine());

            double Addition = First_Number + Second_Number + Third_Number;

            double Multiplication = First_Number * Second_Number * Third_Number;

            Console.WriteLine("\nAddition = " + Addition);

            Console.WriteLine("\nMultiplication = " + Multiplication);

        }
    }
}