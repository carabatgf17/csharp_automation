using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class User3

    {

        // Static Constructor

        static User3()

        {

            Console.WriteLine("I am Static Constructor");

        }

        // Default Constructor

        public User3()

        {

            Console.WriteLine("I am Default Constructor");

        }

    }

    class Program3

    {

        static void Main(string[] args)

        {

            // Both Static and Default constructors will invoke for first instance

            User3 user = new User3();

            // Only Default constructor will invoke

            User3 user1 = new User3();

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }

    }

    // to execute particular action only once throughout the application based on our requirements.
    // ie - environment variable
}
