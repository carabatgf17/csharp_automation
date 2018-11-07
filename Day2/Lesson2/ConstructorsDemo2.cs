using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{

    // Constructor Chaining is an approach to invoke one constructor from another constructor. 
    // To achieve constructor chaining we need to use this keyword after our constructor definition.

    class User2

    {

        public User2()

        {

            Console.Write("Hi, ");

        }

        public User2(string a) : this()

        {

            Console.Write(a);

        }

        public User2(string a, string b) : this("welcome")

        {

            Console.Write(a + " " + b);

        }

    }

    // we created a different constructors with different parameters 
    // and we are calling one constructor from another constructor using this keyword

    class ConstructorsDemo2Tester

    {

        static void Main(string[] args)

        {

            User user1 = new User(" to", "tutlane");

            Console.WriteLine();

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }

    }
}
