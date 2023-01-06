using NUnit.Framework;

namespace Algorithm8
{
    public class Tests
    {
        private int[] Algorithm(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2) {
                return new int[2];
            }

            var numbersMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numbersMap.ContainsKey(nums[i])) {
                    return new int[] { numbersMap[nums[i]], i };
                }

                var numberToFind = target - nums[i];
                numbersMap.TryAdd(numberToFind, i);
            }

            return new int[2];
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var testTarget = 9;
            var testArray = new int[] { 2, 7, 11, 15 };
            var expectedResult = new int[] { 0, 1 };

            // Act
            var result = Algorithm(testArray, testTarget);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var testTarget = 6;
            var testArray = new int[] { 3, 2, 4 };
            var expectedResult = new int[] { 1, 2 };

            // Act
            var result = Algorithm(testArray, testTarget);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var testTarget = 6;
            var testArray = new int[] { 3, 3};
            var expectedResult = new int[] { 0, 1 };

            // Act
            var result = Algorithm(testArray, testTarget);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}