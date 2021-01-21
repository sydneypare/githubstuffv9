using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;


namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        //List Tests!
        #region
        [TestMethod]
        public void List_Empty_string()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("test1");
            Assert.AreEqual(false, q.Empty());

        }

        [TestMethod]
        public void List_Count_string()
        {
            Stack280L<string> q = new Stack280L<string>();
            q.Push("test1");
            q.Push("test1");
            Assert.AreEqual(2, q.Empty());

        }

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
        public void Array_TestPushPop_String()
        {
            Stack280A<string> q = new Stack280A<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void Array_TestPushPeek_String()
        {
            Stack280A<string> q = new Stack280A<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Peek());
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

        [TestMethod]
        public void Array_TestPush1Pop2_String()
        {
            Stack280A<string> q = new Stack280A<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void Array_TestPush2Pop1_Double()
        {
            Stack280A<double> q = new Stack280A<double>();
            q.Push(1.0);
            q.Push(2.0);
            Assert.AreEqual(1.0, q.Pop());
        }

        [TestMethod]
        public void Array_TestPush2Pop1_Int()
        {
            Stack280A<int> q = new Stack280A<int>();
            q.Push(1);
            q.Push(2);
            Assert.AreEqual(1, q.Pop());
        }

        #endregion

    }
}
