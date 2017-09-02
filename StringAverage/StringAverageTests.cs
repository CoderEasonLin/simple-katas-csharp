using NUnit.Framework;

namespace StringAverage
{
    [TestFixture]
    internal class StringAverageTests
    {
        [Test]
        public void string_empty_should_return_na()
        {
            Assert.AreEqual("n/a", StringAverage.Avg(""));
        }

        [Test]
        public void given_one_should_return_one()
        {
            Assert.AreEqual("one", StringAverage.Avg("one"));
        }

        [Test]
        public void given_zero_should_return_zero()
        {
            Assert.AreEqual("zero", StringAverage.Avg("zero"));
        }

        [Test]
        public void given_zero_nine_five_two_should_return_four()
        {
            Assert.AreEqual("four", StringAverage.Avg("zero nine five two"));
        }

        [Test]
        public void given_eleven_should_return_na()
        {
            Assert.AreEqual("n/a", StringAverage.Avg("eleven"));
        }
    }
}