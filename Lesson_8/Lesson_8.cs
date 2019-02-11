using System;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;

            int b = 4;

            double result_1 = a / b;

            Console.Write("    result_1 = " + result_1 +  "\n");

            float result_2 = (float) a / b;

            Console.Write("    result_2 = " + result_2 + "\n");

            if (a % 2 != 0)
            {
                Console.Write("               " + a + " = odd \n");
            }
            else
            {
                Console.Write("               " + a + " = even \n");
            }

            if (b % 2 != 0)
            {
                Console.Write("               " + b + " = odd \n");
            }
            else
            {
                Console.Write("               " + b + " = even \n");
            }

        }
    }
}