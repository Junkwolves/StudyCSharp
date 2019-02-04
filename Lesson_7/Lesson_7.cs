using System;

using System.Globalization;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            string my_str = "45";

            int my_int = int.Parse(my_str);

            string my_str_2 = "7.34";

            try
            {
                double my_int_2 = double.Parse(my_str_2, numberFormatInfo);

                Console.WriteLine("The conversion was successful!");

            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed!");
            }

            string my_str_3 = "45.4";

            double my_int_3;

            bool result = double.TryParse(my_str_3, out my_int_3);

            if (result == true)
            {
                Console.WriteLine("The conversion was successful!");
            }
            else
            {
                Console.WriteLine("Conversion failed!");
            }

        }
    }
}
