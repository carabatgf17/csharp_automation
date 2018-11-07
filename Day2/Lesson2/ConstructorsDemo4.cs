using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class User4

    {

        // private Constructor

        private User4()

        {

            Console.WriteLine("I am Private Constructor");

        }

        public static string name, location;

        // Default Constructor

        public User4(string a, string b)

        {

            name = a;

            location = b;

        }

    }

    class Program4

    {

        static void Main(string[] args)

        {

            // The following comment line will throw an error because constructor is inaccessible

            //User user = new User();



            // Only Default constructor with parameters will invoke

            User4 user1 = new User4("Suresh Dasari", "Hyderabad");

            Console.WriteLine(User4.name + ", " + User4.location);

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }

    }
}

