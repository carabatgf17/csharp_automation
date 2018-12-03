namespace NUnit.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SuccessTests
    {

        [SetUp]
        public void Init()
        { Console.WriteLine("init"); }

        [TearDown]
        public void Cleanup()
        { Console.WriteLine("cleanup"); }

        [Test]
        public void Add()
        { Console.WriteLine("add"); }

        [Test]
        public void delete()
        { Console.WriteLine("delete"); }


    }
}
