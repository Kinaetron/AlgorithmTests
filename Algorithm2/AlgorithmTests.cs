using NUnit.Framework;

namespace Algorithm2
{
    public class Tests
    {
        private bool Algorithm(int[] nums)
        {
            var lookedAt = new HashSet<int>();
            foreach (var number in nums)
            {
                if (lookedAt.Contains(number)) {
                    return true;
                }

                lookedAt.Add(number);
            }

            return false;
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var intArray = new int[] { 1, 2, 3, 1 };

            // Act
            var result = Algorithm(intArray);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var intArray = new int[] { 1, 2, 3, 4 };

            // Act
            var result = Algorithm(intArray);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var intArray = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            // Act
            var result = Algorithm(intArray);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}