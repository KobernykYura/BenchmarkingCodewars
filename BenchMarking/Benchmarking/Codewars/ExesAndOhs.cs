namespace Benchmarking.Codewars
{
    /// <summary>
    /// XO("ooxx") => true
    /// XO("xooxx") => false
    /// XO("ooxXm") => true
    /// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
    /// XO("zzoo") => false
    /// </summary>
    public class ExesAndOhs
    {
        static readonly char[] charsXO = new char[] { 'x', 'o' };

        public static bool XO_GroupJoin_Distinct(string input)
        {
            // each character is considered to be a key
            Func<char, char> keySelector = sourceChar => sourceChar;

            // aggregate function for each group
            Func<char, IEnumerable<char>, int> resultSelector = (key, elements) => elements.Count();

            // group letters by  its char avalue & inner join with ['x', 'o'] keys
            IEnumerable<int> xoCounts = charsXO
              .GroupJoin(
                input.ToLowerInvariant(), // chars we need to intersect (join) to group
                keySelector, // inner selector
                keySelector, // outer selector
                resultSelector // aggreagte result for a group
              );

            int destinctCountsLenght = xoCounts.Distinct().Count();

            return destinctCountsLenght <= 1;
        }

        public static bool XO_GroupJoin_All(string input)
        {
            // each character is considered to be a key
            Func<char, char> keySelector = sourceChar => sourceChar;

            // aggregate function for each group
            Func<char, IEnumerable<char>, int> resultSelector = (key, elements) => elements.Count();

            // group letters by  its char avalue & inner join with ['x', 'o'] keys
            IEnumerable<int> xoCounts = charsXO
              .GroupJoin(
                input.ToLowerInvariant(), // chars we need to intersect (join) to group
                keySelector, // inner selector
                keySelector, // outer selector
                resultSelector // aggreagte result for a group
              );

            if(!xoCounts.Any())
            {
                return false;
            }

            int first = xoCounts.First();

            return xoCounts.All(c => c == first);
        }

        public static bool XO_Where_Count(string input)
        {
            string lowercased = input.ToLower();
            int o = lowercased.Where(o => o == 'o').Count();
            int x = lowercased.Where(x => x == 'x').Count();

            return x == o ? true : false;
        }

        public static bool XO_Loop(string input)
        {
            int count = 0;
            string text = input.ToLower();

            if (input.Length <= 0)
                return true;

            if (!text.Contains('x') || !text.Contains('o'))
                return false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'x' || text[i] == 'o')
                    count++;
            }

            return count % 2 == 0;
        }
    }
}
