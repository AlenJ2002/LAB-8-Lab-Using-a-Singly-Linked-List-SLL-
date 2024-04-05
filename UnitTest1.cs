using NUnit.Framework;
using SLL; 
using System;

namespace SLLTests
{
    [TestFixture]
    public class LinkedListTests
    {
        private LinkedList list; // field

        [SetUp]
        public void Setup()
        {
            list = new LinkedList(); // setup
        }

        [Test]
        public void AddFirst_AddsNodeToBeginning() // method
        {
            list.AddFirst("John Smith");
            Assert.AreEqual("John Smith", list.Head.Value); // add first
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void AddLast_AddsNodeToEnd() // method
        {
            list.AddLast("Jane Doe");
            Assert.AreEqual("Jane Doe", list.GetValue(0)); // add last
            Assert.AreEqual(1, list.Count); // add last
        }

        [Test]
        public void RemoveFirst_RemovesHeadNode() // method
        {
            list.AddFirst("Joe Blow");
            list.RemoveFirst();
            Assert.IsNull(list.Head);
            Assert.AreEqual(0, list.Count); // remove first
        }

        [Test]
        public void RemoveLast_RemovesLastNode() // method
        {
            list.AddFirst("Joe Blow");
            list.RemoveLast();
            Assert.IsNull(list.Head);
            Assert.AreEqual(0, list.Count); // remove last
        }

        [Test]
        public void GetValue_RetrievesCorrectValueByIndex() // method
        {
            list.AddLast("Joe Blow");
            list.AddLast("John Smith");
            Assert.AreEqual("John Smith", list.GetValue(1)); // get value
        }

        [Test]
        public void Count_ReturnsCorrectSize() // method
        {
            list.AddLast("Joe Blow");
            list.AddLast("John Smith");
            Assert.AreEqual(2, list.Count); // count
        }

        [Test]
        public void GetValue_WithInvalidIndex_ThrowsException() // method
        {
            list.AddLast("Joe Blow");
            Assert.Throws<ArgumentOutOfRangeException>(() => list.GetValue(2)); // out of range
        }
    }
}
