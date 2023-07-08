using System.Text;

namespace Benchmarking.Codewars
{
    //In this kata you are required to, given a string, replace every letter with its position in the alphabet.
    //If anything in the text isn't a letter, ignore it and don't return it.
    //"a" = 1, "b" = 2, etc.

    // "a" is ANSCII 65
    // "z" is ANSCII 90

    public static class AlphabetPosition
    {
        public static string AlphabetPosition_CharValueMinus64(string text)
        {
            IEnumerable<int> charArrayAsIntegers = text.ToUpper()
              .Where(char.IsLetter)
              .Select(e => e - 64);

            return string.Join(" ", charArrayAsIntegers);
        }

        #region KataSolutions

        public static string AlphabetPosition_StringOfLowerCaseLetters(string text)
        {
            return string.Join(" ", text.ToLower()
                .Where(c => char.IsLetter(c))
                .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
                .ToArray());
        }

        public static string AlphabetPosition_SelectWithUmpersant(string text)
        {
            return string.Join(" ", text.Where(char.IsLetter).Select(c => c & 31));
        }

        public static string AlphabetPosition_StringBuilder(string text)
        {
            StringBuilder sb = new StringBuilder(text.Length * 3);

            foreach (char ch in text.ToLower())
            {
                if (ch < 'a' || ch > 'z') continue;
                sb.Append(ch - '`');
                sb.Append(' ');
            }

            return sb.ToString().Trim();
        }

        public static string AlphabetPosition_IndexInLowerCasedAlphabet(string text)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<string> Nums = new List<string>();

            foreach (char c in text)
            {
                if (alphabet.Contains(c.ToString().ToLower()))
                    Nums.Add((alphabet.IndexOf(c.ToString().ToLower()) + 1).ToString());
            }

            string result = string.Join(" ", Nums.ToArray());

            return result;
        }

        #endregion
    }
}
