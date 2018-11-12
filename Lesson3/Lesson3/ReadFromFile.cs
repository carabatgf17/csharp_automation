﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class ReadFromFile
    {
        static void Main()
        {
            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.

            // Example #1
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"TextFile1.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"TextFile1.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");


            int counter = 0;
            string line1;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"TextFile1.txt");
            while ((line1 = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line1);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();


            System.Console.ReadKey();
        }

    }
}
