using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class ForEachCollectionsDemo
    {
        public static void Main()
        {
            var myList = new List<string>() { "one", "two", "three" };
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class ForCollectionsDemo
    {
        public static void Main()
        {
            // List<T>
            var myList = new List<int>() { 43, 55, 100 };
            for (int i = 0; i < myList.Count; i++)
            {
                // access current element of the list with index of i
                Console.WriteLine(myList[i]);
            }

            // array
            int[] numbers = new[] { 2, 3, 5, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                // access current element of the array with index of i
                Console.WriteLine(numbers[i]);
            }
        }
    }

    public class WhileCollectionsDemo
    {
        public static void Main()
        {
            var myList = new List<int>() { 10, 20, 30 };
            int index = 0;
            while (index < myList.Count)
            {
                Console.WriteLine(myList[index]);
                index++;
            }
        }
    }



}
