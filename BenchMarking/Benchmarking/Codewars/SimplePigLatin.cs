using System.Text.RegularExpressions;

namespace Benchmarking.Codewars
{
    /// <summary>
    /// Move the first letter of each word to the end of it,
    /// then add "ay" to the end of the word.
    /// Leave punctuation marks untouched.
    /// </summary>
    public static class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            var pigSentence = Regex.Replace(str, "(\\w+)", EvaluatePigMatch);

            return pigSentence;
        }

        private static string EvaluatePigMatch(Match word)
        {
            Span<char> pigLetters = stackalloc[] { 'a', 'y' };

            ReadOnlySpan<char> firstLetter = word.ValueSpan[..1];
            ReadOnlySpan<char> restLetters = word.ValueSpan[1..];

            return string.Concat(restLetters, firstLetter, pigLetters);
        }

        #region KataSolutions

        public static string PigIt_JoinsSplitsAndLinq(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
        }

        public static string PigIt_RegexReplace_CapturedNotWhitespacePosition(string str)
        {
            // capturing portions of the match and saving them as placeholders
            return Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");
        }

        public static string PigIt_RegexReplace_CapturedWordPosition(string str)
        {
            // capturing portions of the match and saving them as placeholders
            return Regex.Replace(str, @"\b(\w)(\w+)\b", "$2$1ay");
        }

        #endregion
    }

}

