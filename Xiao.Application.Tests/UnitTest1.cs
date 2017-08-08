using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xiao.Application;
using Xiao.Application.PracticalPattern.Concept.Delegating;
using System.Threading;
namespace Xiao.Application.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person p = new Person();
            string value = p.Func();
            Assert.AreEqual<string>("Hello", value);
        }
        [TestMethod]
        public void TestAsyncInvoker()
        {
            AsyncInvoker asyncInvoker = new AsyncInvoker();
            Thread.Sleep(3000);
            Assert.AreEqual<string>("method", asyncInvoker.Output[0]);
            Assert.AreEqual<string>("fast", asyncInvoker.Output[1]);
            Assert.AreEqual<string>("slow", asyncInvoker.Output[2]);
        }
    }
}
