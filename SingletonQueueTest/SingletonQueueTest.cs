using System;
using SingletonQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingletonQueueTest {

    [TestClass]
    public class SingletonQueueTest {

        [TestMethod]
        public void CanaryTest() {
            SingletonQueue<int> queue = SingletonQueue<int>.Instance;
            Assert.AreNotEqual(null, queue);
        }

        [TestMethod]
        public void PushTest() {
            SingletonQueue<int> queue = SingletonQueue<int>.Instance;
            queue.Push(1);
            queue.Push(2);

            string result = queue.ToString();
            Assert.AreEqual("1, 2", result);

            queue.ClearQueue();
        }

        [TestMethod]
        public void PopTest() {
            SingletonQueue<int> queue = SingletonQueue<int>.Instance;
            queue.Push(1);
            queue.Push(2);

            string result = queue.ToString();
            Assert.AreEqual("1, 2", result);

            int item = queue.Pop();
            result = queue.ToString();

            Assert.AreEqual(1, item);
            Assert.AreEqual("2", result);

            queue.ClearQueue();
        }
    }
}
