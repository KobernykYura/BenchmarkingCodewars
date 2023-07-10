namespace Benchmarking.Codewars
{
    //The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
    //What if the string is empty? Then the result should be empty object literal, {}.

    public static class CountStringCharacter
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> dictianarySet = new();

            if (string.IsNullOrWhiteSpace(str))
            {
                return dictianarySet;
            }

            foreach (var character in str)
            {
                if (dictianarySet.TryGetValue(character, out int keyValue))
                {
                    dictianarySet[character] = ++keyValue;
                }

                if (dictianarySet.TryAdd(character, 1))
                {
                    continue;
                }
            }

            return dictianarySet;
        }

        #region KataSolutions

        public static Dictionary<char, int> Count_GroupBy(string str)
        {
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }

        #endregion
    }
}
