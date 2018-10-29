using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class VariousEntryPoints
    {
        public VariousEntryPoints()
        {
        }

        static void Main(string[] args)
        {
            Console.Out.Write("Enter a string - ");
            string testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", testString);
            Console.ReadKey();

        }
    }
}
