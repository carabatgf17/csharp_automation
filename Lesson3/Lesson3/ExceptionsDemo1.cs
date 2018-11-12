using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                // To see the error, try changing to or adding invalid numbers
                int sum = SumNumberStrings(new List<string> { "5", "4" });
                Console.WriteLine(sum);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("List of numbers contained an invalid entry.");
            }
        }

        public static int SumNumberStrings(List<string> numbers)
        {
            int total = 0;
            foreach (string numberString in numbers)
            {
                total += int.Parse(numberString);
            }
            return total;
        }

    }
}
