namespace Benchmarking.Codewars
{
    //You are given an array(list) 'strarr' of strings and an integer 'k'.
    //Your task is to return the first longest string consisting of k consecutive strings taken in the array.

    public class LongestConsecutives
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            if (k < 1 || k > strarr.Length)
            {
                return string.Empty;
            }

            int maxStartIndex = 0;
            int maxCharLength = 0;

            for (int startIndex = 0, endIndex = startIndex + k; endIndex <= strarr.Length; startIndex++, endIndex = startIndex + k)
            {
                int concatLength = 0;
                string[] subArray = strarr[startIndex..endIndex];

                foreach (string item in subArray)
                {
                    concatLength += item.Length;
                }

                if (concatLength > maxCharLength)
                {
                    maxCharLength = concatLength;
                    maxStartIndex = startIndex;
                }
            }

            return string.Join(string.Empty, strarr, maxStartIndex, k);
        }

        #region KataSolutions

        public static string LongestConsec_ConcatStringsEachIteration(string[] strarr, int k)
        {
            if (k > strarr.Length || strarr.Length == 0 || k <= 0)
            {
                return string.Empty;
            }

            var currentStr = string.Empty;
            for (var i = 0; i < strarr.Length; i++)
            {
                var str = string.Empty;
                for (var j = i; j < k + i && j < strarr.Length; j++)
                {
                    str += strarr[j];
                }

                if (currentStr.Length < str.Length)
                {
                    currentStr = str;
                }
            }

            return currentStr;
        }

        public static string LongestConsec_LinqSkipTake(string[] s, int k)
        {
            return s.Length == 0 || s.Length < k || k <= 0 ? ""
                 : Enumerable.Range(0, s.Length - k + 1)
                             .Select(x => string.Join("", s.Skip(x).Take(k)))
                             .OrderByDescending(x => x.Length)
                             .First();
        }

        #endregion
    }
}
