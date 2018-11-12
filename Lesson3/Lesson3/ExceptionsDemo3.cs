using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    public class ExceptionsDemo3
    {
        public static void Main()
        {
            try
            {
                // uncomment either line to see an error
                int.Parse("A");
                //throw new Exception();
            }

            // change the catch order
            catch (System.FormatException e)
            {
                Console.WriteLine("This is a System.FormatException");
               
            }
            catch (System.Exception)
            {
                Console.WriteLine("This is a different System.Exception");
            }

        }
    }
}

