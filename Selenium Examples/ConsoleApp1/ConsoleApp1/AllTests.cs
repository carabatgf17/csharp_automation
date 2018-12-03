namespace NUnit.Tests
{
    using System;
    using NUnit.Framework;
    using NUnit.Framework.Internal;

    public class AllTests
    {
        //[Suite]
        public static TestSuite Suite
        {
            get
            {
                TestSuite suite = new TestSuite("All Tests");
               // suite.Add(new ConsoleApp1.TestCase3());
                return suite;
            }
        }
    }
}

