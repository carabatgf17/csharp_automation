using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class ListsDemo
    {
        static void Main()
        {
            List<int> someInts = new List<int>(); // declares an empty list
            someInts.Add(2);  // the list now has one item in it: {2}
            Console.WriteLine($"someInts[0]: {someInts[0]}");

            List<int> moreInts = new List<int>() { 2, 3, 4 }; // you can initialize a list when you create it
            Console.WriteLine($"moreInts[0]: {moreInts[0]}");

            string[] colors = "red,blue,yellow,green".Split(','); // an array of 4 strings
            List<string> colorList = new List<string>(colors); // initialize the list from an array
            Console.WriteLine($"colorList[0]: {colorList[0]}");
        }
    }

    class ListsDemo2
    {
        static void Main()
        {
            List<string> colors = new List<string>() { "black", "white", "gray" };
            colors.Remove("black");
            colors.Insert(0, "orange"); // orange is the new black
            Console.WriteLine($"colors[0] {colors[0]}");

            colors.RemoveAll(c => c.Contains("t")); // removes all elements matching condition (containing a "t")
                                                    // colors currently: orange, gray
            Console.WriteLine($"colors[1] {colors[1]}");

            colors.RemoveAt(0); // removes the first element (orange)
            Console.WriteLine($"colors[0] {colors[0]}");

            int numColors = colors.Count; // Count currently is 1
            Console.WriteLine($"numColors: {numColors}");

            colors.Clear(); // colors is now an empty list
            Console.WriteLine($"colors.Count: {colors.Count}");
        }
    }



}
