using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class User6

    {

        public string name, location;

        public long marks = 470;

        public User6(string name, string location)

        {

            // Use this to distinguish between parameters and variables

            this.name = name;

            this.location = location;

        }

        public void GetUserDetails()

        {

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Location: {0}", location);

            // Passing a class instance to the method using this

            Console.WriteLine("Marks: {0}", Exams.GetPercentage(this));

        }

    }

    class Exams

    {

        public static double GetPercentage(User6 u)

        {

            double i = ((double)470 / 600) * 100;

            Console.WriteLine(u.marks);
            return (i);

        }

    }



    class Program6

    {

        static void Main(string[] args)

        {

            User6 u = new User6("Gabriel", "Cluj");

            u.GetUserDetails();

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }

    }


}
