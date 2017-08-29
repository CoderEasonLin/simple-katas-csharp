﻿using NUnit.Framework;

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
        public void given_two_should_return_two()
        {
            Assert.AreEqual("two", StringAverage.Avg("two"));
        }

        [Test]
        public void given_zero_should_return_zero()
        {
            Assert.AreEqual("zero", StringAverage.Avg("zero"));
        }

        [Test]
        public void given_one_one_should_return_one()
        {
            Assert.AreEqual("one", StringAverage.Avg("one one"));
        }

        [Test]
        public void given_one_two_should_return_one()
        {
            Assert.AreEqual("one", StringAverage.Avg("one two"));
        }

        [Test]
        public void given_two_one_should_return_one()
        {
            Assert.AreEqual("one", StringAverage.Avg("two one"));
        }

        [Test]
        public void given_three_five_should_return_four()
        {
            Assert.AreEqual("four", StringAverage.Avg("three five"));
        }

        [Test]
        public void given_zero_nine_five_two_should_return_four()
        {
            Assert.AreEqual("four", StringAverage.Avg("zero nine five two"));
        }
    }
}