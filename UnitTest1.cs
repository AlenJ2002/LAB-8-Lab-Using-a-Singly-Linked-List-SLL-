using NUnit.Framework;
using SLL; 
using System;

namespace SLLTests
{
    [TestFixture]
    public class LinkedListTests
    {
        private LinkedList list;

        [SetUp]
        public void Setup()
        {
            list = new LinkedList();
            // You can populate the list here if needed
        }

        [Test]
        public void AddFirst_AddsNodeToBeginning()
        {
            list.AddFirst("John Smith");
            Assert.AreEqual("John Smith", list.Head.Value);
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void AddLast_AddsNodeToEnd()
        {
            list.AddLast("Jane Doe");
            Assert.AreEqual("Jane Doe", list.GetValue(0));
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void RemoveFirst_RemovesHeadNode()
        {
            list.AddFirst("Joe Blow");
            list.RemoveFirst();
            Assert.IsNull(list.Head);
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void RemoveLast_RemovesLastNode()
        {
            list.AddFirst("Joe Blow");
            list.RemoveLast();
            Assert.IsNull(list.Head);
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void GetValue_RetrievesCorrectValueByIndex()
        {
            list.AddLast("Joe Blow");
            list.AddLast("John Smith");
            Assert.AreEqual("John Smith", list.GetValue(1));
        }

        [Test]
        public void Count_ReturnsCorrectSize()
        {
            list.AddLast("Joe Blow");
            list.AddLast("John Smith");
            Assert.AreEqual(2, list.Count);
        }

        [Test]
        public void GetValue_WithInvalidIndex_ThrowsException()
        {
            list.AddLast("Joe Blow");
            Assert.Throws<ArgumentOutOfRangeException>(() => list.GetValue(2));
        }
    }
}
