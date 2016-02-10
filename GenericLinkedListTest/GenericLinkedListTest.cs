using System;
using GenericLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericLinkedListTest {
    
    [TestClass]
    public class GenericLinkedListTest {
    
        [TestMethod]
        public void CanaryTest() {
            GenericLinkedList<int> result = new GenericLinkedList<int>();
            Assert.AreNotEqual(null, result);
        }

        [TestMethod]
        public void AddToEndTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            string result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1, 2", result);
        }

        [TestMethod]
        public void AddAtTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            string result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1, 2", result);

            list.AddAt(3, 2);

            result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1, 3, 2", result);
        }

        [TestMethod]
        public void AddToTopTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToTop(1);
            list.AddToTop(2);
            string result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("2, 1", result);
        }

        [TestMethod]
        public void RemoveTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            string result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1, 2", result);

            list.Remove(2);

            result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void RemoveAtLastTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            string result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1, 2", result);

            list.RemoveAt(2);

            result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void RemoveAtFirstTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            string result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1, 2", result);

            list.RemoveAt(1);

            result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void RemoveAtMidTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);
            string result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1, 2, 3", result);

            list.RemoveAt(2);

            result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1, 3", result);
        }

        [TestMethod]
        public void RemoveAtFirstWhenThereIsOneNodeTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToEnd(1);
            string result = list.ToString();
            Assert.AreNotEqual(string.Empty, result);
            Assert.AreEqual("1", result);

            list.RemoveAt(1);

            result = list.ToString();
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ReadAtTest() {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            list.AddToEnd(1);
            list.AddToEnd(2);
            list.AddToEnd(3);
            string output = list.ToString();
            Assert.AreNotEqual(string.Empty, output);
            Assert.AreEqual("1, 2, 3", output);

            int result = list.ReadAt(2);
            Assert.AreEqual(2, result);

        }
    }
}
