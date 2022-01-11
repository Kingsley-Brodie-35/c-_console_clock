using NUnit.Framework;
using Count;

namespace ClockTest
{
    public class Tests
    {
        private Clock _clock;
        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }
        //Test to see _count is initialised to 0 when object created.
        [Test]
        public void SecondsAt0()
        {
            Assert.AreEqual(0, _clock.Seconds);
        }
        [Test]
        public void MinutesAt0()
        {
            Assert.AreEqual(0, _clock.Minutes);
        }
        [Test]
        public void HoursAt0()
        {
            Assert.AreEqual(0, _clock.Hours);
        }
        //incrementing the counter adds one to seconds
        [Test]
        public void Increment()
        {
            _clock.Tick();
            Assert.AreEqual(1, _clock.Seconds);
        }
        //Incrementing counter multiple times
        [Test]
        public void IncrementMultiple()
        {
            for (int i = 0; i < 20; ++i)
            {
                _clock.Tick();
            }
            Assert.AreEqual(20, _clock.Seconds);
        }
        //Resetting the timer sets count to 0
        [Test]
        public void Reset()
        {
            _clock.Reset();
            StringAssert.AreEqualIgnoringCase("00:00:00", _clock.Time);
        }
        //Seconds reset after one minute
        [Test]
        public void SecondsReset()
        {
            for(int i = 0; i < 60; ++i)
            {
                _clock.Tick();
            }
            Assert.AreEqual(1, _clock.Minutes);
            Assert.AreEqual(0, _clock.Seconds);
        }
        //minutes reset after one hour
        [Test]
        public void MinutesReset()
        {
            _clock.Reset();
            for(int i = 0; i < 3600; ++i)
            {
                _clock.Tick();
            }
            Assert.AreEqual(1, _clock.Hours);
            Assert.AreEqual(0, _clock.Minutes);
        }
        //clock resets after 24 hours
        [Test]
        public void HoursReset()
        {
            _clock.Reset();
            for (int i = 0; i < 86400; ++i)
            {
                _clock.Tick();
            }
            Assert.AreEqual(0, _clock.Hours);
            Assert.AreEqual(0, _clock.Minutes);
            Assert.AreEqual(0, _clock.Seconds);
        }
    }
}