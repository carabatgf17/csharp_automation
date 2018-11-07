using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class User

    {

        public string name, location;

        // Default Constructor

        public User()

        {

            name = "Gabriel Carabat";

            location = "Cluj-Napoca";

        }
        // Parameterized Constructor - at least one parameter
        public User(string a, string b)

        {

            name = a;

            location = b;

        }



    }

    class UserTester

    {

        static void Main(string[] args)

        {

            // The constructor will be called automatically once the instance of class created

            User user = new User();

            Console.WriteLine(user.name);

            Console.WriteLine(user.location);

            // The constructor will be called automatically once the instance of class created

            User user2 = new User("Gabriel Carabat", "Cluj-Napoca");

            Console.WriteLine(user2.name);

            Console.WriteLine(user2.location);

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();


        }

    }
}
