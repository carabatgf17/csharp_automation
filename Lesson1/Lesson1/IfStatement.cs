using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /**
     * 
     * The if statement is used to evaluate a boolean expression 
     * before executing a set of statements. If an expression evaluates to true, 
     * then it will run one set of statements else it will run another set of statements.
     * 
     * */
     
    class IfStatement
    {
        public static void Main()
        {
            Int32 value = 11;

            if (value < 10)
            {
                Console.WriteLine("Value is less than 10");
            }
            else
            {
                Console.WriteLine("Value is greater than 10");
            }
            Console.ReadKey();
        }

    }
}

