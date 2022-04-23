using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpday5
{
    internal class Flipcoin
    {
        public static void FindFlipcoin()
        {
            int tailCount = 0;
            int headCount = 0;
            Random obj = new Random();
            Console.WriteLine("Enter the number of times to flipcoin");
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTimes; i++)
            {
                double input = obj.NextDouble();
                if (input < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("tailCount:{0} headCount:{0},tailCout,headCount ");
            double tailPercentage = (tailCount * 100)/numberOfTimes;
            double headPercentage = (headCount * 100)/numberOfTimes;
            Console.WriteLine("Head Percentage:{0}% tail Percentage:{1}%", headPercentage, tailPercentage);
        }
    }
}
