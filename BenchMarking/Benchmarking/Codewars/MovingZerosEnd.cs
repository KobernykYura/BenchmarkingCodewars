using System.Buffers;

namespace Benchmarking.Codewars
{
    /// <summary>
    /// Write an algorithm that takes an array and moves all of the zeros to the end,
    /// preserving the order of the other elements.
    /// </summary>
    public class MovingZerosEnd
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] MoveZeroes_Linq(int[] arr)
        {
            int zeroesCount = arr.Count(IsZero);
            int[] zeroes = new int[zeroesCount];

            return arr.Where(item => !IsZero(item))
                .Concat(zeroes)
                .ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] MoveZeroes_ArraySort(int[] arr)
        {
            int[] newArray = new int[arr.Length];

            Array.ConstrainedCopy(arr, 0, newArray, 0, arr.Length);
            Array.Sort<int>(newArray, ItemComparer);

            return newArray;
        }

        /// <summary>
        /// Compare if item equals to zero.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private static bool IsZero(int item) => item.Equals(0);

        /// <summary>
        /// Implementation of IComparer<T> interaface.
        /// </summary>
        /// <param name="leftItem"></param>
        /// <param name="rightItem"></param>
        /// <returns></returns>
        private static int ItemComparer(int leftItem, int rightItem)
        {
            if (
                (leftItem is 0 && rightItem is 0) ||
                (leftItem is not 0 && rightItem is not 0)
            )
            {
                return 0;
            }

            if (leftItem is 0)
            {
                return 1;
            }

            return -1;
        }
    }
}