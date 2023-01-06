using NUnit.Framework;

namespace Algorithm4
{
    public class Tests
    {
        private int Algorithm(string s)
        {
            var characters = new Dictionary<char, int>();

            foreach (var character in s)
            {
                if (characters.ContainsKey(character)) {
                    ++characters[character];
                }
                else {
                    characters.Add(character, 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (characters[s[i]] == 1) {
                    return i;
                }
            }

            return -1;
        }
        #region
        [Test]
        public void Test1()
        {
            // Arrange
            var testString = "leetcode";

            // Act
            var result = Algorithm(testString);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var testString = "loveleetcode";

            // Act
            var result = Algorithm(testString);

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var testString = "aabb";

            // Act
            var result = Algorithm(testString);

            // Assert
            Assert.That(result, Is.EqualTo(-1));
        }
        #endregion
    }
}