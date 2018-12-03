namespace NUnit.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Success2Tests
    {

        [OneTimeSetUp]
        public void Init()
        { Console.WriteLine("init"); }

        [OneTimeTearDown]
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

