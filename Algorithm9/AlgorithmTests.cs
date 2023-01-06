using NUnit.Framework;

namespace Algorithm9
{
    public class Tests
    {
        private int Algorithm(int[] nums)
        {
            var numbers = new HashSet<int>();

            foreach (var number in nums) {
                numbers.Add(number);
            }

            for (int i = 0; i <= nums.Length; i++)
            {
                if (!numbers.Contains(i)) {
                    return i;
                }
            }

            return int.MinValue;
        }


        [Test]
        public void Test1()
        {
            // Arrange
            var testArray = new int[] { 3, 0, 1 };
            var expectedResult = 2;

            // Act
            var result = Algorithm(testArray);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var testArray = new int[] { 0, 1 };
            var expectedResult = 2;

            // Act
            var result = Algorithm(testArray);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var testArray = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            var expectedResult = 8;

            // Act
            var result = Algorithm(testArray);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}