using Benchmarking.Codewars;

namespace Benchmarking.UnitTests.Codewars
{
    [TestFixture("Pig latin is cool", "igPay atinlay siay oolcay")]
    [TestFixture("This is my string", "hisTay siay ymay tringsay")]
    [TestFixture("Hello world !", "elloHay orldway !")]
    [TestFixture("Thank you, Joshuah.", "hankTay ouyay, oshuahJay.")]
    public class SimplePigLatinTests
    {
        private string _sentence;
        private string _pigSentence;

        public SimplePigLatinTests(string sentence, string expected)
        {
            this._sentence = sentence;
            this._pigSentence = expected;
        }

        [Test]
        public void PigIt()
        {
            string actual = SimplePigLatin.PigIt(_sentence);

            Assert.That(actual, Is.EqualTo(_pigSentence));
        }

        #region KataSolutions

        [Test]
        public void PigIt_JoinsSplitsAndLinq()
        {
            // This method doesn't properly handle punctuation marks.
            string actual = SimplePigLatin.PigIt_JoinsSplitsAndLinq(_sentence);

            Assert.That(actual, Is.EqualTo(_pigSentence));
        }

        [Test]
        public void PigIt_RegexReplace_CapturedNotWhitespacePosition()
        {
            // This method doesn't properly handle punctuation marks.
            string actual = SimplePigLatin.PigIt_RegexReplace_CapturedNotWhitespacePosition(_sentence);

            Assert.That(actual, Is.EqualTo(_pigSentence));
        }

        [Test]
        public void PigIt_RegexReplace_CapturedWordPosition()
        {
            string actual = SimplePigLatin.PigIt_RegexReplace_CapturedWordPosition(_sentence);

            Assert.That(actual, Is.EqualTo(_pigSentence));
        }

        #endregion
    }
}
