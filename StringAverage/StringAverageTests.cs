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
    }
}