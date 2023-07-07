using System.Text;

namespace Benchmarking.Codewars
{
    //  a = "xyaabbbccccdefww"
    //  b = "xxxxyyyyabklmopq"
    //  longest(a, b) -> "abcdefklmopqwxy"
    //
    //  a = "abcdefghijklmnopqrstuvwxyz"
    //  longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"

    public static class TwoToOne
    {
        private static readonly StringBuilder strBuilder = new StringBuilder();

        public static string Longest_HashSet_SortedSet_NewString(string s1, string s2)
        {
            ISet<char> uniqueValues = new HashSet<char>(s1.Union(s2));
            ISet<char> sortedUniqueValues = new SortedSet<char>(uniqueValues);

            return new string(sortedUniqueValues.ToArray());
        }

        public static string Longest_HashSet_SortedSet_StringBuilderAggregate(string s1, string s2)
        {
            ISet<char> uniqueValues = new HashSet<char>(s1.Union(s2));
            ISet<char> sortedUniqueValues = new SortedSet<char>(uniqueValues);

            return uniqueValues
                .Aggregate(strBuilder.Clear(), (acc, value) => acc.Append(value))
                .ToString();
        }

        public static string Longest_HashSet_SortMethod_StringBuilderAggregate(string s1, string s2)
        {
            ISet<char> uniqueValues = new HashSet<char>(s1.Union(s2));
            List<char> sortedUniqueValues = uniqueValues.ToList();
            
            sortedUniqueValues.Sort((left, right) => left.CompareTo(right));

            return uniqueValues
                .Aggregate(strBuilder.Clear(), (acc, value) => acc.Append(value))
                .ToString();
        }

        #region KataSolutionsRegion
        
        public static string Longest_Distinct_OrderBy_NewString(string s1, string s2)
        {
            return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());
        }
        public static string Longest_Distinct_OrderBy_StringConcat(string s1, string s2)
        {
            return string.Concat((s1 + s2).Distinct().OrderBy(c => c));
        }

        public static string Longest_Union_OrderBy_NewString(string s1, string s2)
        {
            char[] merged = s1.Union(s2)
                .OrderBy(x => x)
                .ToArray();

            return new string(merged);
        }

        #endregion
    }
}
