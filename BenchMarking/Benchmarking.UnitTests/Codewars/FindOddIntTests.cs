using Benchmarking.Codewars;

namespace Benchmarking.UnitTests.Codewars
{
    [TestFixture(5, new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 })]
    public class FindOddIntTests
    {
        private readonly int expected;
        private readonly int[] input;

        public FindOddIntTests(int exp, int[] ints)
        {
            this.expected = exp;
            this.input = ints;
        }

        [Test]
        public void Find_GroupBy()
        {
            int result = FindOddInt.Find_GroupBy(this.input);

            Assert.That(result, Is.EqualTo(this.expected));
        }

        [Test]
        public void Find_LogicalExclusive()
        {
            int result = FindOddInt.Find_LogicalExclusive(this.input);

            Assert.That(result, Is.EqualTo(this.expected));
        }

        [Test]
        public void Find_Aggregate_LogicalExclusive()
        {
            int result = FindOddInt.Find_Aggregate_LogicalExclusive(this.input);

            Assert.That(result, Is.EqualTo(this.expected));
        }

        [Test]
        public void Find_Dictionary()
        {
            int result = FindOddInt.Find_Dictionary(this.input);

            Assert.That(result, Is.EqualTo(this.expected));
        }
    }
}
