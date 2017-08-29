using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WordCount
{
    [TestFixture]
    internal class WordCountTests
    {
        [Test]
        public void string_empty_should_return_0()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int>(), WordCount.Count(""));
        }

        [Test]
        public void given_a_should_return_correctly()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> {{"a", 1}}, WordCount.Count("a"));
        }

        [Test]
        public void given_a_a_should_return_correctly()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> {{"a", 2}}, WordCount.Count("a a"));
        }

        [Test]
        public void given_a_b_c_should_return_correctly()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> {{"a", 1}, {"b", 1}, {"c", 1}},
                WordCount.Count("a b c"));
        }

        [Test]
        public void given_a_b_b_b_c_c_should_return_correctly()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> {{"b", 3}, {"c", 2}, {"a", 1}},
                WordCount.Count("a b b b c c"));
        }

        [Test]
        public void requirement_test_should_return_correctly()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int> {{"olly", 2}, {"in", 1}, {"come", 1}, {"free", 1}},
                WordCount.Count("olly olly in come free"));
        }
    }
}