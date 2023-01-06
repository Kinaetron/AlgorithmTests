using NUnit.Framework;

namespace Algorithm3
{
    public class Tests
    {
        private void Algorithm(char[] s)
        {
            var leftIndex = 0;
            var rightIndex = s.Length - 1;

            while (leftIndex <= rightIndex)
            {
                var temp = s[leftIndex];
                s[leftIndex] = s[rightIndex];
                s[rightIndex] = temp;

                ++leftIndex;
                --rightIndex;
            }
        }

        #region Tests
        [Test]
        public void Test1()
        {
            // Arrange
            var charArray = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var expectedResult = new char[] { 'o', 'l', 'l', 'e', 'h' };

            // Act
            Algorithm(charArray);

            // Assert
            Assert.That(charArray, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var charArray = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            var expectedResult = new char[] { 'h', 'a', 'n', 'n', 'a', 'H' };

            // Act
            Algorithm(charArray);

            // Assert
            Assert.That(charArray, Is.EqualTo(expectedResult));
        }
        #endregion
    }
}