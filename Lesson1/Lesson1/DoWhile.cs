using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements

{   // The while loop simply executes a block of code as long as the condition you give it is true

    class While
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }

            Console.ReadLine();
        }
    }

    // the do loop - The opposite is true for the do loop, which works
    // like the while loop in other aspects through. The do loop evaluates the condition after the loop has 
    // executed, which makes sure that the code block is always executed at least once

    class DoWhile
    {
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                Console.WriteLine(number);
                number = number + 1;
            } while (number < 5);
            Console.ReadLine();
        }
    }

}
