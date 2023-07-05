using System.Text;
using System.Text.RegularExpressions;

namespace Benchmarking.Codewars
{
    //  Kata.Maskify("4556364607935616"); // should return "############5616"
    //  Kata.Maskify("64607935616");      // should return "#######5616"
    //  Kata.Maskify("1");                // should return "1"
    //  Kata.Maskify("");                 // should return ""

    //  "What was the name of your first pet?"
    //  Kata.Maskify("Skippy");                                   // should return "##ippy"
    //  Kata.Maskify("Nananananananananananananananana Batman!"); // should return "####################################man!"

    public class Maskify
    {
        // return masked string
        public static string Regex_NegativeLookAhead(string cc)
        {
            // a pattern matching
            // - each character "."
            // - except "(?! ...)"
            // - last four charactes ".{0,3}$"
            string pattern = @".(?!.{0,3}$)";

            // replace each matched character with '#'
            string replacement = "#";

            // used Substitutions in Regular Expressions
            return Regex.Replace(cc, pattern, replacement);
        }

        public static string Regex_PositiveLookAhead(string cc)
        {
            if (cc.Length < 5)
                return cc;

            string pattern = @".(?=.{3})";

            // replace each matched character with '#'
            string replacement = "#";

            // used Substitutions in Regular Expressions
            return Regex.Replace(cc, pattern, replacement);
        }

        // return masked string
        public static string Substring_PadLeft(string cc)
        {
            int len = cc.Length;
            if (len <= 4)
                return cc;

            return cc.Substring(len - 4).PadLeft(len, '#');
        }

        private static readonly int UNCHANGED = 4;
        private static readonly char MASK_VAL = '#';

        // return masked string
        public static string StringBuilder(string cc)
        {
            StringBuilder sb = new StringBuilder(cc);
            for (int i = 0; i < sb.Length - UNCHANGED; ++i)
                sb[i] = MASK_VAL;

            return sb.ToString();
        }
    }
}
