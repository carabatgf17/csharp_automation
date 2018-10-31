using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    // The switch statement is like a set of if statements. It's a list of possibilities,
    // with an action for each possibility, and an optional default action,
    // in case nothing else evaluates to true

    class Switch1
    {
        public static void Main()
        {
            int number = 1;
            switch (number)
            {
                case 0:
                    Console.WriteLine("The number is zero!");
                    break;
                case 1:
                    Console.WriteLine("The number is one!");
                    break;
            }

        }
    }
    /**
     * 
     * The identifier to check is put after the switch keyword, 
     * and then there's the list of case statements, where we check the identifier
     * against a given value. You will notice that we have a break statement at the
     * end of each case. C# simply requires that we leave the block before it ends.
     * In case you were writing a function, you could use a return statement instead
     * of the break statement.In this case, we use an integer, but it could be a string too,
     * or any other simple type. Also, you can specify the same action for multiple cases.
     * We will do that in the next example too, where we take a piece of input from the user
     * and use it in our switch statement:
     * 
     * */

    class Switch2
    {
        public static void Main()
        {
            Console.WriteLine("Do you enjoy C# ? (yes/no/maybe)");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "yes":
                case "maybe":
                    Console.WriteLine("Great!");
                    break;
                case "no":
                    Console.WriteLine("Too bad!");
                    break;
            }
        }
    }
}
