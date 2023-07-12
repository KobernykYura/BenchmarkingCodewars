using Benchmarking.Codewars;

namespace Benchmarking.UnitTests.Codewars
{
    [TestFixture(new[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2, "abigailtheta")]
    [TestFixture(new[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1, "oocccffuucccjjjkkkjyyyeehh")]
    [TestFixture(new[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2, "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck")]
    [TestFixture(new[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2, "wlwsasphmxxowiaxujylentrklctozmymu")]
    [TestFixture(new[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2, "")]
    [TestFixture(new[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3, "ixoyx3452zzzzzzzzzzzz")]
    [TestFixture(new[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15, "")]
    [TestFixture(new[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0, "")]
    [TestFixture(new string[] { }, 3, "")]
    public class LongestConsecutivesTests
    {
        private readonly string _expected;
        private readonly int _concatQuantity;
        private readonly string[] _strings;

        public LongestConsecutivesTests(string[] str, int concQ, string exp)
        {
            this._concatQuantity = concQ;
            this._strings = str;
            this._expected = exp;
        }

        [Test]
        public void LongestConsec_Test()
        {
            var result = LongestConsecutives.LongestConsec(this._strings, this._concatQuantity);

            Assert.That(result, Is.EqualTo(this._expected));
        }

        [Test]
        public void LongestConsec_ConcatStringsEachIteration()
        {
            var result = LongestConsecutives.LongestConsec_ConcatStringsEachIteration(this._strings, this._concatQuantity);

            Assert.That(result, Is.EqualTo(this._expected));
        }

        [Test]
        public void LongestConsec_LinqSkipTake()
        {
            var result = LongestConsecutives.LongestConsec_LinqSkipTake(this._strings, this._concatQuantity);

            Assert.That(result, Is.EqualTo(this._expected));
        }
    }
}