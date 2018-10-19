using ApplicationUnderTest;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestClass testClass = new TestClass();
            Assert.AreEqual("Hello World", testClass.Test());
        }
    }
}
