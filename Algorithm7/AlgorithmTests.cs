using NUnit.Framework;

namespace Algorithm7
{
    public class Tests
    {
        private readonly Dictionary<char, char> mappings = new Dictionary<char, char>()
        {
             { ')', '(' },
             { '}', '{' },
             { ']', '[' }
        };

        private bool Algorithm(string symbols)
        {
            if (symbols == "") {
                return true;
            }

            if (symbols.Length % 2 != 0) {
                return false;
            }

            var stack = new Stack<char>();

            for (int i = 0; i < symbols.Length; i++)
            {
                var character = symbols[i];

                if (mappings.ContainsKey(character))
                {
                    char topElement = stack.Count == 0 ? '#' : stack.Pop();

                    if (topElement != mappings[character]) {
                        return false;
                    }
                }
                else {
                    stack.Push(character);
                }
            }

            return stack.Count == 0;
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var testString = "()";

            // Act
            var result = Algorithm(testString);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            var testString = "()[]{}";

            // Act
            var result = Algorithm(testString);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var testString = "(]";

            // Act
            var result = Algorithm(testString);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}