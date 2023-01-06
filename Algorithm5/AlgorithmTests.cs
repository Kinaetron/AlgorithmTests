using NUnit.Framework;

namespace Algorithm5
{
    public class Tests
    {
        private bool Algorithm(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var sArray = s.ToCharArray();
            var tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != tArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var testString1 = "anagram";
            var testString2 = "nagaram";

            var result = Algorithm(testString1, testString2);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var testString1 = "rat";
            var testString2 = "car";

            var result = Algorithm(testString1, testString2);

            Assert.That(result, Is.False);
        }
    }
}