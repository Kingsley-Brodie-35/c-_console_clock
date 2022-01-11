using NUnit.Framework;
using Count;

namespace ClockTest
{
    public class Tests
    {
        private Counter _count;
        [SetUp]
        public void Setup()
        {
            _count = new Counter("c");
        }
        //Test to see _count is initialised to 0 when object created.
        [Test]
        public void StartsAt0()
        {
            Assert.AreEqual(0, _count.Count);
        }
        //incrementing the counter adds one to the count
        [Test]
        public void Increment()
        {
            _count.Increment();
            Assert.AreEqual(1, _count.Count);
        }
        //Incrementing counter multiple times
        [Test]
        public void IncrementMultiple()
        {
            for(int i = 0; i < 20; i++)
            {
                _count.Increment();
            }
            Assert.AreEqual(20, _count.Count);
        }
        //Resetting the timer sets count to 0
        [Test]
        public void Reset()
        {
            _count.Reset();
            Assert.AreEqual(0, _count.Count);
        }
    }
}