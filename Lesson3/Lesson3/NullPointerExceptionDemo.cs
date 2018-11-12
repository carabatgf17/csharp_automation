using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Person

    {
        public int age = 10;
        public string name;
        public int GetAge()
        
        {

            return age;

        }

        public void SetAge(int age)

        {

            this.age = age;

        }

    }

    class NullPointerExceptionDemo

    {

        static void Main(string[] args)

        {

            Person p = null;
            Console.WriteLine(p.GetAge());
            Console.ReadLine();

        }

    }

}

