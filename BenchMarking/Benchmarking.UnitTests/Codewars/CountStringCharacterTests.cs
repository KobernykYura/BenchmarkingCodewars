using Benchmarking.Codewars;

namespace Benchmarking.UnitTests.Codewars
{
    [TestFixture]
    public class CountStringCharacterTests
    {
        [Test]
        public void FixedTest_aaaa()
        {
            Dictionary<char, int> d = new Dictionary<char, int>
            {
                { 'a', 4 }
            };
            Assert.That(CountStringCharacter.Count("aaaa"), Is.EqualTo(d));
        }

        [Test]
        public void FixedTest_aabb()
        {
            Dictionary<char, int> d = new Dictionary<char, int>
            {
                { 'a', 2 },
                { 'b', 2 }
            };
            Assert.That(CountStringCharacter.Count("aabb"), Is.EqualTo(d));
        }

        [Test]
        public void FixedTest_aaaa_GroupBy()
        {
            Dictionary<char, int> d = new Dictionary<char, int>
            {
                { 'a', 4 }
            };
            Assert.That(CountStringCharacter.Count_GroupBy("aaaa"), Is.EqualTo(d));
        }

        [Test]
        public void FixedTest_aabb_GroupBy()
        {
            Dictionary<char, int> d = new Dictionary<char, int>
            {
                { 'a', 2 },
                { 'b', 2 }
            };
            Assert.That(CountStringCharacter.Count_GroupBy("aabb"), Is.EqualTo(d));
        }
    }
}
