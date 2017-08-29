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
    }
}