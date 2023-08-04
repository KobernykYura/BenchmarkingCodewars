using Benchmarking.Codewars;

namespace Benchmarking.UnitTests.Codewars
{
    [TestFixture]
    public class MovingZerosEndTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }, new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 0, 4, 0, 1, 0, 3, 0, 1 }, new int[] { 1, 2, 4, 1, 3, 1, 0, 0, 0, 0 })]
        [TestCase(new int[] { 5, 6, 3, 3, 4, 5, 0, 0, 9, 0 }, new int[] { 5, 6, 3, 3, 4, 5, 9, 0, 0, 0 })]
        public void MoveZeroes_Linq_Test(int[] input, int[] expected)
        {
            int[] result = MovingZerosEnd.MoveZeroes_Linq(input);

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }, new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 0, 4, 0, 1, 0, 3, 0, 1 }, new int[] { 1, 2, 4, 1, 3, 1, 0, 0, 0, 0 })]
        [TestCase(new int[] { 5, 6, 3, 3, 4, 5, 0, 0, 9, 0 }, new int[] { 5, 6, 3, 3, 4, 5, 9, 0, 0, 0 })]
        public void MoveZeroes_ArraySort_Test(int[] input, int[] expected)
        {
            int[] result = MovingZerosEnd.MoveZeroes_ArraySort(input);

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected, result);
        }
    }
}