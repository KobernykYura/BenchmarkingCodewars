using System.Text.RegularExpressions;

namespace Benchmarking.Codewars
{
    //Write a function that accepts an array of 10 integers(between 0 and 9), that returns a string of those numbers in the form of a phone number.

    //Example
    //Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
    //The returned format must be correct in order to complete this challenge.

    //Don't forget the space after the closing parentheses!

    public static class CreatePhoneNumber
    {
        public static string CreatePhoneNumber_StringFormat_SelectToStringArray(int[] numbers)
        {
            return string.Format(
                "({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
                numbers.Select(s => s.ToString()).ToArray()
            );
        }

        #region KataSolutions

        public static string CreatePhoneNumber_LongParse_Concat_ToString(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }

        public static string CreatePhoneNumber_RegexReplace_Grouping(int[] numbers)
        {
            return Regex.Replace("(...)(...)(....)", string.Concat(numbers), "($1) $2-$3");
        }

        public static string CreatePhoneNumber_StringFormat_SkipTake(int[] numbers)
        {
            return string.Format("({0}) {1}-{2}",
              numbers.Take(3).Select(n => n.ToString()).Aggregate((a, b) => a + b),
              numbers.Skip(3).Take(3).Select(n => n.ToString()).Aggregate((a, b) => a + b),
              numbers.Skip(6).Take(4).Select(n => n.ToString()).Aggregate((a, b) => a + b)
            );
        }

        public static string CreatePhoneNumber_StringFormat_ParseULong_StringJoin(int[] numbers)
        {
            return string.Format("{0:(000) 000-0000}", ulong.Parse(String.Join("", numbers)));
        }

        #endregion
    }
}
