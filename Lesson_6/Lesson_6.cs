using System;

namespace Lesson_5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string my_str_1 = "1";

            string my_str_2 = "2";

            Console.WriteLine("\n str a = " + my_str_1 + " str b = " + my_str_2 + "\n");

            Console.WriteLine(" str a + str b = " + my_str_1 + my_str_2 + "\n");

            short my_int_1 = Convert.ToInt16(my_str_1);

            short my_int_2 = Convert.ToInt16(my_str_2);

            Console.WriteLine(" Convert str a to short a | Convert str b to short b \n");

            int result = my_int_1 + my_int_2;

            Console.WriteLine(" int result = a + b = " + result + "\n");


        }
    }
}