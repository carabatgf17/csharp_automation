using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class VariousEntryPoints1
    {
        static void main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }

    class VariousEntryPointsInApp2
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
            return 0;
        }
    }

    class VariousEntryPointsInApp3
    {
        static int Main()
        {
            Console.WriteLine("Hello World - int Main");
            Console.ReadKey();
            return 0;
        }
    }

    class VariousEntryPointsInApp4
    {
        static int Main(int [] args)
        {
            Console.WriteLine("Hello World - int args");
            Console.ReadKey();
            return 0;
        }
    }
}
