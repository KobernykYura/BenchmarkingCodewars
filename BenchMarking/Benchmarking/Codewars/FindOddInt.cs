namespace Benchmarking.Codewars
{
    public class FindOddInt
    {
        public static int Find_GroupBy(int[] seq)
        {
            var grouped = seq.DefaultIfEmpty(-1).GroupBy(number => number);
            var firstOddGroup = grouped.FirstOrDefault(group => (group.Count() % 2) > 0);

            return firstOddGroup?.Key ?? -1;
        }

        #region KataSolutions

        public static int Find_LogicalExclusive(int[] seq)
        {
            int found = 0;

            foreach (var num in seq)
            {
                found ^= num;
            }

            return found;
        }
        public static int Find_Aggregate_LogicalExclusive(int[] seq)
        {
            return seq.Aggregate(0, (a, b) => a ^ b);
        }

        public static int Find_Dictionary(int[] seq)
        {
            Dictionary<int, int> numbersWithTimes = new Dictionary<int, int>();

            foreach (var number in seq)
            {
                if (!numbersWithTimes.ContainsKey(number))
                {
                    numbersWithTimes.Add(number, 1);
                }
                else
                {
                    numbersWithTimes[number]++;
                }
            }

            foreach (KeyValuePair<int, int> item in numbersWithTimes)
            {
                if (item.Value % 2 == 1)
                    return item.Key;
            }

            return -1;
        }

        #endregion
    }
}
