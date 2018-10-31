using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class RelationalOperator
    {
        public static void Main(string[] args)
        {
            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber);
            Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber > secondNumber);
            Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber < secondNumber);
            Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber >= secondNumber);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber <= secondNumber);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber != secondNumber);
            Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
        }


    }
}
