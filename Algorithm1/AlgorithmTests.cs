using NUnit.Framework;

namespace Algorithm1
{
    public class Tests
    {
        private int Algorithm(int[] nums)
        {
            if (nums.Length == 1) {
                return nums[0];
            }

            var runningCount = new Dictionary<int, int>();

            foreach (var number in nums)
            {
                if (runningCount.ContainsKey(number)) {
                    runningCount[number]++;
                }
                else {
                    runningCount.Add(number, 1);
                }
            }

            foreach (var pair in runningCount)
            {
                if (pair.Value == 1) {
                    return pair.Key;
                }
            }

            return 0;
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var numberArray = new int[] { 2, 2, 1 };

            // Act
            var result = Algorithm(numberArray);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var numberArray = new int[] { 4, 1, 2, 1, 2 };

            // Act
            var result = Algorithm(numberArray);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }
    }
}