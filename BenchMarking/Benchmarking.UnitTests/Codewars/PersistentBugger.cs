using Benchmarking.Codewars;

namespace Benchmarking.UnitTests.Codewars
{
    [TestFixture(3, 39)]
    [TestFixture(0, 4)]
    [TestFixture(2, 25)]
    [TestFixture(4, 999)]
    public class PersistentBuggerTests
    {
        long expected;
        long input;

        public PersistentBuggerTests(long expected, long input)
        {
            this.expected = expected;
            this.input = input;
        }

        [Test]
        public void Persistence()
        {
            long actual = PersistentBugger.Persistence(this.input);

            Assert.That(actual, Is.EqualTo(this.expected));
        }

        [Test]
        public void Persistence_StringParse_Aggregate()
        {
            long actual = PersistentBugger.Persistence_StringParse_Aggregate(this.input);

            Assert.That(actual, Is.EqualTo(this.expected));
        }

        [Test]
        public void Persistence_LongValues()
        {
            long actual = PersistentBugger.Persistence_LongValues(this.input);

            Assert.That(actual, Is.EqualTo(this.expected));
        }

        [Test]
        public void Persistence_Recursive()
        {
            long actual = PersistentBugger.Persistence_Recursive(this.input);

            Assert.That(actual, Is.EqualTo(this.expected));
        }
    }
}