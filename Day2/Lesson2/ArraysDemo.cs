using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class ArraysDemo
    {

        // You can store multiple variables of a particular type in an array data structure

        static void Main()
        {
            // Arrays must be declared by specifying the type of its elements

            int[] someIntegers = new int[3]; // holds 3 elements, with indexes of 0, 1, and 2.
                                             // uninitialized elements of a declared array hold the default value for the type (in this case 0).
            Console.WriteLine(someIntegers[0]);
            Console.WriteLine(someIntegers[1]);
            Console.WriteLine(someIntegers[2]);

            int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 }; // initializes the values of the array
            Console.WriteLine(moreIntegers[0]);
            Console.WriteLine(moreIntegers[1]);
            Console.WriteLine(moreIntegers[2]);
            // write out more if you like

            int[] otherIntegers = new[] { 1, 3, 5, 7, 9 }; // you can omit `int` and just specify []; type is inferred
            Console.WriteLine(otherIntegers[0]);
            Console.WriteLine(otherIntegers[1]);
            Console.WriteLine(otherIntegers[2]);
            // write out more if you like
        }
    }


    class TwoDimesionalArraysDemo
    {
        static void Main()
        {
            int[,] eggCarton = new int[2, 6]; // a typical egg carton can be thought of as a 2x6 array
            Console.WriteLine(eggCarton[0, 0]); // one "corner" of the array
            Console.WriteLine(eggCarton[1, 5]); // the opposite "corner"

            int[,] someTable = { { 1, 2, 3 }, { 4, 5, 6 } }; // you can fill a multi-dimensional array on assignment as well
            Console.WriteLine(someTable[0, 0]); // one "corner" of the array
            Console.WriteLine(someTable[1, 2]); // the opposite "corner"
        }
    }

    class ArraysUsageDemo
    {
        static void Main()
        {
            int[] someIntegers = { 1, 2, 3 };

            int x = 1 + someIntegers[0]; // x = 2
            Console.WriteLine(x);

            int y = 2 * someIntegers[2]; // y = 6
            Console.WriteLine(y);

            someIntegers[2] = y; // someIntegers now contains { 1, 2, 6 }
            Console.WriteLine(someIntegers[0]);
            Console.WriteLine(someIntegers[1]);
            Console.WriteLine(someIntegers[2]);

            // following lines produces an exception
            someIntegers[3] = 3; // EXCEPTION
        }
    }

    class StringArrays
    {
        static void Main()
        {
            string input = "red,blue,yellow,green";
            // note single quotes, which are used to define literal character (``char``) values
            string[] colors = input.Split(','); 

            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
        }
    }

    class StringSplitAndJoin
    {
        static void Main()
        {
            string input = "red,blue,yellow,green";
            string[] colors = input.Split(','); 

            string output = String.Join(" | ", colors);
            Console.WriteLine(output);
        }
    }


}
