using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class ExceptionsDemo2
    {
        public static void Main()
        {
            try
            {
                DoWork();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("We encountered an error. Please try again.");
                Console.WriteLine(ex.Message);
                
                //Console.WriteLine(ex.StackTrace);
            }
        }

        public static void DoWork()
        {
            try
            {
                FindStudentId(null);
            }
            catch (ArgumentNullException ex)
            {
                // You would do some safe clean up work or logging here
                // Logger.LogError(ex);
                throw;
                // ureachable code
                Console.WriteLine("DoWork");
            }
        }

        public static int FindStudentId(string studentName)
        {
            if (string.IsNullOrEmpty(studentName))
            {
                throw new ArgumentNullException(nameof(studentName));
            }

            return 0; // we didn't really implement this
        }
    }

}
