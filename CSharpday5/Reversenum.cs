using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpday5
{
    internal class Reversenum
    {
        public static int Findreverse()
        {
            int reverse = 0;
            int remainder = 0;
            Console.WriteLine("Enter the number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number>0)
            {
                remainder = number % 10;
                reverse = (reverse * 10 + remainder);
                number = number / 10;

            }
            Console.WriteLine("reverse number is : " +reverse);
            return reverse;
        }
    }
}
