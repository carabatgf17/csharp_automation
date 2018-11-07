using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class DestructorDemo

    {

        public DestructorDemo()

        {

            Console.WriteLine("An Instance of class created");

        }

        // Destructor

        ~DestructorDemo()

        {

            Console.WriteLine("An Instance of class destroyed");

        }

    }

    class DestructorDemoTester

    {

        static void Main(string[] args)

        {

            Details();

            GC.Collect();

            Console.ReadLine();

        }

        public static void Details()

        {

            // Created instance of class

            DestructorDemo user = new DestructorDemo();

        }

    }


}
