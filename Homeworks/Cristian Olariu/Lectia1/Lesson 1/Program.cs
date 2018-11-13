using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson_1
{
    class VariousEntryPoints1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world! - void");
            Console.ReadKey();
        }
    }

    class VariousEntryPointsInApp2
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello world! - int");
            Console.ReadKey();
            return 0;
        }
    }
    class VariousEntryPointsInApp3
    {
        static int Main()
        {
            Console.WriteLine("Hello world! - int no arg");
            Console.ReadKey();
            return 0;
        }
    }

    class Calculator
    {
        static int Main(string[] args)
        {
            Console.Write("Enter the expression: ");
            string testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", testString);
            Regex regexForOperands = new Regex(@"(\d+(\.\d+)?)|(\.\d+)", RegexOptions.IgnoreCase);
            Match match = regexForOperands.Match(testString);
            decimal operand1 = 0;
            if (match.Success)
            {
                operand1 = Decimal.Parse(match.Value);
            }
            else
            {
                Console.WriteLine("Bad operator in first position");
                return 1;
            }
            decimal operand2 = 0;
            match = match.NextMatch();
            if (match.Success)
            {
                operand2 = Decimal.Parse(match.Value);
            }
            else
            {
                Console.WriteLine("Bad operator in second position");
                return 1;
            }
            decimal result;
            Regex regexForOperator = new Regex(@"[+\-\*\/]");
            match = regexForOperator.Match(testString);
            char @operator = match.Value[0];
            switch (@operator)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    result = operand1 / operand2;
                    break;
                default:
                    Console.WriteLine("Operator is not recognized.");
                    return 1;
            }
            Console.Write("...calculating the result\n\t{0} {1} {2} = {3}\n", operand1, @operator, operand2, result);
            return 0;
        }
    }
    class Regx
    {
        static int Main(string[] args)
        {
            //string text = @"12+34-45*44";
            Console.Write("Enter the expression: ");
            string text = Console.ReadLine();
            string pattern = @"(\d+(\.\d+)?)|(\.\d+)";
            Regex myRegex = new Regex(pattern, RegexOptions.IgnoreCase);

            Match m = myRegex.Match(text);   // m is the first match
            Console.Write("first value"+ m.Value + "\n");
            while (m.Success)
            {
                // Do something with m
                Console.Write(m.Value + "\n");
                m = m.NextMatch();              // more matches
            }
            Console.Read();
            return 0;
        }
    }
}
