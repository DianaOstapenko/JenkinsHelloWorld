using System;
using ApplicationUnderTest;
using NUnit.Framework;

namespace NUnitHelloWorldTests
{
    [TestFixture]
    public class UNitTests
    {
        [Test]
        public void TestMethod1()
        {
            TestClass testClass = new TestClass();
            Assert.AreEqual("Hello World", testClass.Test());
        }
        [Test]
        public void TestMethod2()
        {
            TestClass testClass = new TestClass();
            Assert.AreEqual("Hello World", testClass.Test());
        }
        [Test]
        public void TestMethod3()
        {
            TestClass testClass = new TestClass();
            Assert.AreEqual("Hello World", testClass.Test());
        }
        [Test]
        public void TestMethod4()
        {
            TestClass testClass = new TestClass();
            Assert.AreEqual("Hello World", testClass.Test());
        }
        [Test]
        public void TestMethodFailture()
        {
            TestClass testClass = new TestClass();
            Assert.AreEqual("Hello World2", testClass.Test());
        }
    }
    }
