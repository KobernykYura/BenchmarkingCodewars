namespace Benchmarking.Codewars
{
    // Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence,
    // which is the number of times you must multiply the digits in num until you reach a single digit.
    
    // For example(Input --> Output):
    
    // 39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
    // 999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
    // 4 --> 0 (because 4 is already a one-digit number)

    public static class PersistentBugger
    {
        public static int Persistence(long n)
        {
            int iterationIndex = 0;

            if (n < 10)
            {
                return iterationIndex;
            }

            long multiplicativePersistence = 1;

            while (n >= 10)
            {
                // count multiplicative persistence number with each digit
                while (n > 0)
                {
                    multiplicativePersistence *= n % 10;
                    n /= 10;
                }

                // replace the input number to handle the next iteration with a new value
                n = multiplicativePersistence;

                // set to default for the next count iteration
                multiplicativePersistence = 1;

                iterationIndex++;
            }

            return iterationIndex;
        }

        #region KataSolutions

        public static int Persistence_StringParse_Aggregate(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }

        public static int Persistence_LongValues(long n)
        {
            int i = 0;
            while (n > 9l)
            {
                long mul = 1l;

                while (n > 0l)
                {
                    mul *= n % 10l;
                    n /= 10l;
                }

                n = mul;
                i++;
            }

            return i;
        }

        public static int Persistence_Recursive(long n)
        {
            long nF = n.ToString().Aggregate(1, (a, b) => a * (b - '0'));
            return n < 9 ? 0 : 1 + Persistence_Recursive(nF);
        }

        #endregion
    }
}
