using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    //Using a for loop, you can easily write a loop that will print a list of numbers to the screen:
    class ForLoop1
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
    class ForLoop2
    {
        public static void Main()
        {
            int startingNumber = 5; // change to whatever value you want to start from
            int endingNumber = 10; // change to whatever number you want to be the last displayed

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    // Counting Up By Different Increments

    class ForLoop3
    {
        public static void Main()
        {
            Console.WriteLine("Odd Numbers from 1-49:");
            for (int i = 1; i < 50; i += 2)
            {
                Console.WriteLine(i);
            }

        }
    }
    // Counting Down

    class ForLoop4
    {
        public static void Main()
        {
            Console.WriteLine("Countdown started...");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("LIFTOFF!");


        }
    }
}
