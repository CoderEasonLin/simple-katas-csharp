using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WordCount
{
    [TestFixture]
    class WordCountTests
    {
        [Test]
        public void string_empty_should_return_0()
        {
            CollectionAssert.AreEqual(new Dictionary<string, int>(), WordCount.Count(""));
        }

    }
}
