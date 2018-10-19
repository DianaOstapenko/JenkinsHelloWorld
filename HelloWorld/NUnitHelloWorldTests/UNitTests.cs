using System;
using HelloWorld;
using NUnit.Framework;

namespace NUnitHelloWorldTests
{
    [TestFixture]
    public class UNitTests
    {
            [Test]
            public void TestMethod1()
            {
                Assert.AreEqual("Hello World", Program.CreateMessage());
            }
        }
    }
