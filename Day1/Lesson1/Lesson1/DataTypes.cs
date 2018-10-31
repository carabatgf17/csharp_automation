using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{/**
    *
    * Class that handle different types of variables
    * 
    * */
    class DataTypes
    {   
        //calendar
        enum Days {Sun, Mon, Tue, Wed,Thu, Fri, Sat };
        // entry point of any App or program
        static void Main(string[] args)
        {   
            short @short = 1;
            double @for = 1;
           
            Days aaaaa = Days.Fri;

            Console.WriteLine(@short);
            Boolean status=true;
            Console.WriteLine(status);

            Int32 num = 30;
            Int64 num64 = 1010100101010;
            Double num2 = 30.33;
            String hw = "Hello World";

            Console.WriteLine(num);
            Console.WriteLine("Hello {0} {1}", hw,@short);
            Console.WriteLine(num64);
            Console.WriteLine(num2);
            Console.WriteLine(Days.Fri);
            Console.WriteLine(hw);
            Console.ReadKey();

        }
    }
}
