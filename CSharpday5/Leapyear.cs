    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpday5
{
    internal class Leapyear
    {
        public static int Year;

        public static void checkyearinput()
        {
            Console.WriteLine("Enter the year: ");
            Year = Convert.ToInt32(Console.ReadLine());
            if (Year / 1000 != 0 && Year / 1000 < 10)
            {
                Console.WriteLine("Enter the number is four digit no");
            }
            else
            {
                Console.WriteLine("Enter the number is not a four digit no");
            }

        }
        public static void Yearmethod()
        {
            Console.WriteLine();
            Console.WriteLine("Leap year program");
            checkyearinput();

            if (Year / 1000 != 0 && Year / 1000 < 10)
            {
                if (((Year %4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine("{0} is leap year", Year);
                }
                else
                {
                    Console.WriteLine("{0} is not leap year", Year);
                }
                Console.WriteLine("leap year ends");
            }

        }
    }
}
