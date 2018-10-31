using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class LogicalOperator
    {
        public static void Main(string[] args)
        {
            bool result;
            int firstNumber = 10, secondNumber = 20;

            // OR operator
            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            // AND operator
            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);

            // AND operator
            bool first = false; bool second = true;
            result = (first) && (second);
            Console.WriteLine(result);
            
        }
    }
}
