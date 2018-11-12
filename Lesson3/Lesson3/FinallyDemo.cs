using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class FinallyDemo
    {
        static void Main(string[] args)
        {
            int zero = 0;

            try
            {
                int result = 5 / zero;  // this will throw an exception       
            }

            catch (Exception ex)
            {
                Console.WriteLine("Inside catch block. Exception: {0}", ex.Message);
            }

            finally
            {
                Console.WriteLine("Inside finally block.");
            }
        }

    }
}
