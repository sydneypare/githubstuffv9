using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;
using System;

namespace PostFixTest
{
    [TestClass]
    public class PostFixTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Array_TestPushPeek_String()
        {
           // RPNCalc<string> r = new RPNCalc<string><string>();
            //q.Push("First");
            //Assert.AreEqual("First", q.Peek());
        }

        [TestMethod]
        public void Array_TestPush3Pop1_String()
        {
            Stack280A<string> q = new Stack280A<string>();
            q.Push("First");
            q.Push("Second");
            q.Push("Third");
            Assert.AreEqual("Second", q.Pop());
        }

        [TestMethod]
        public void Array_TestPush3Peek_String()
        {
            Stack280A<string> q = new Stack280A<string>();
            q.Push("number1");
            q.Push("number2");
            q.Push("number3");
            Assert.AreEqual("number1", q.Peek());
        }



    }
}
