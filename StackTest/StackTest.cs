using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;


namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void TestMethod1()
        {


        }

        //List Tests!

        #region
        [TestMethod]
        public void List_TestPushPop_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void List_TestPushPeek_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Peek());
        }

        [TestMethod]
        public void List_TestPush3Pop1_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            q.Push("Second");
            q.Push("Third");
            Assert.AreEqual("Second", q.Pop());
        }

        [TestMethod]
        public void List_TestPush3Peek_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("number1");
            q.Push("number2");
            q.Push("number3"); 
            Assert.AreEqual("number1", q.Peek());
        }

        [TestMethod]
        public void List_TestPush1Pop2_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void List_TestPush2Pop1_Double()
        {
            Stack280L<double> q = new Stack280L<double>();
            q.Push(1.0);
            q.Push(2.0);
            Assert.AreEqual(1.0, q.Pop());
        }

        [TestMethod]
        public void List_TestPush2Pop1_Int()
        {
            Stack280L<int> q = new Stack280L<int>();
            q.Push(1);
            q.Push(2);
            Assert.AreEqual(1, q.Pop());
        }
        #endregion


        //array tests!

        #region

        [TestMethod]
        public void List_TestPushPop_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void List_TestPushPeek_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Peek());
        }

        [TestMethod]
        public void List_TestPush3Pop1_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void List_TestPush3Peek_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Peek());
        }

        [TestMethod]
        public void List_TestPush1Pop2_String()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void List_TestPush2Pop1_Double()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Peek());
        }

        [TestMethod]
        public void List_TestPush2Pop1_Int()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Peek());
        }
        #endregion

    }
}
